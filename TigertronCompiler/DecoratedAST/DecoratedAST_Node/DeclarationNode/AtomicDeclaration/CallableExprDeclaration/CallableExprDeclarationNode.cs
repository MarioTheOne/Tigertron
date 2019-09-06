using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class CallableExprDeclarationNode : StatementDeclarationNode
    {
        #region	Fields and Properties

        //this property will be setted in CheckSemantic method
        public TypeExpression ReturnType { get; set; }

        private InstructionNode _body;
        public InstructionNode Body
        {
            get { return _body ?? (_body = GetChild(2) as InstructionNode); }
        }

        private List<FieldNode> _parameters;
        public List<FieldNode> Parameters
        {
            get
            {
                if (_parameters == null)
                {
                    _parameters = new List<FieldNode>();
                    var paramsSignature = GetChild(1);
                    for (int i = 0; i < paramsSignature.ChildCount; i++)
                        _parameters.Add(paramsSignature.GetChild(i) as FieldNode);
                }
                return _parameters;
            }
        }

        #endregion

        #region	Builder Methods

        protected CallableExprDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckHeaderSemantic(errors, symbolTable))
            {
                int initErr = errors.Count;
                //Check Params(types and names)
                for (int i = 0; i < Parameters.Count; i++)
                {
                    Parameters[i].CheckSemantic(errors, symbolTable);
                    for (int j = i + 1; j < Parameters.Count; j++)
                    {
                        if (Parameters[i].Identifier == Parameters[j].Identifier)//exist two parameters of functions with the same name
                        {
                            string message = string.Format("The parameter named '{0}' already exist in this function", Parameters[i].Identifier);
                            errors.Add(new Error(message, Parameters[j].Line, Parameters[j].CharPositionInLine));
                        }
                    }
                }
                TypeExpression expectedType;
                if (CheckExpectedType(symbolTable,errors, out expectedType))
                    ReturnType = expectedType;
                if (initErr == errors.Count)//no ocurrio ningun error en la signatura
                {
                    ProcessDeclaration(symbolTable);
                    return true;
                }
                ProcessUndefinedDeclaration(symbolTable);    
            }
            return false;

        }

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            //Note: si llega aki entonces tuvo bien el CheckHeaderSemantic
            int initErr = errors.Count;
            symbolTable.OpenScope(ScopeType.Function);
            //Add parameters in function scope Note: esto es lo unico que va a tener un scope de tipo function
            foreach (var param in Parameters.Where(param=>!(param.FieldType is ErrorType)))
                symbolTable.InsertDeclaration(new FieldSymbol(param.Identifier, param.FieldType));

            //Check Body
            //Note: si tuvo problemas con su definicion entonces no se podra utilizar en ninguna parte, incluyendo su cuerpo
            string decMessage = string.Format("The retunr type is mismatched");
            if (Body.CheckSemantic(errors, symbolTable))
                if (ReturnType != null) CheckAssigment(Body, ReturnType, errors, decMessage); //Check return ILType

            //le pongo el identificador del scope al body del functionSymbol
            var functionSymbol = symbolTable.MappingDeclaration<FunctionSymbol>(Identifier);
            functionSymbol.BodyScopeId = symbolTable.TopScope.Id;

            symbolTable.CloseScope();
            if (initErr == errors.Count)
            {
                Scope = symbolTable.TopScope.Clone();
                return true;
            }
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            //obtenemos el functionSymbol
            var funSymbol = Scope.MappingDeclaration<FunctionSymbol>(Identifier);

            if (funSymbol.MethodBuilder == null)
            {
                //Creamos el metodo correspondiente a la funcion
                MethodBuilder function = cg.TypeBuilder.DefineMethod(Identifier + "_" + Scope.Id, MethodAttributes.Public | MethodAttributes.Static,
                                                                     ReturnType.PrimitiveType.ILType, Parameters.Select(i => i.FieldType.PrimitiveType.ILType).ToArray());

                //Creamos los variables globales para cada uno de los parametros
                List<FieldBuilder> paramGlobals = new List<FieldBuilder>();
                var fieldAttr = FieldAttributes.Public | FieldAttributes.Static;
                foreach (var item in Parameters)
                {
                    paramGlobals.Add(cg.TypeBuilder.DefineField(item.Identifier + "_" + item.Scope.Id, item.FieldType.PrimitiveType.ILType, fieldAttr));
                }

                //Rellenamos los campos del FunctionSymbol
                funSymbol.MethodBuilder = function;
                funSymbol.ParameterFieldBuilders = paramGlobals;
            }

            //Rellenamos los FieldSymbols con una referencia a al FieldBuilder correspondiente en el FunctionSymbol
            for (int i = 0; i < Parameters.Count; i++)
            {
                var field = Body.Scope.MappingDeclaration<FieldSymbol>(Parameters[i].Identifier);
                field.FieldBuilder = funSymbol.ParameterFieldBuilders[i];

                //cg.GetGenerator.Emit(OpCodes.Ldarg, i+1);
                //cg.GetGenerator.Emit(OpCodes.Stsfld, funSymbol.ParameterFieldBuilders[i]);
            }

            //Creamos el ILCodeGenerator para la funcion y generamos su cuerpo
            var ilGen = funSymbol.MethodBuilder.GetILGenerator();
            var funGen = new ILCodeGenerator(cg, ilGen);
            Body.GenCode(funGen);
            ilGen.Emit(OpCodes.Ret);
        }

        #endregion

        #region	Auxiliar Methods

        protected virtual bool CheckExpectedType(SymbolTable symbolTable, List<Error> errors, out TypeExpression expectedType)
        {
            expectedType = TypeExpression.VoidType;
            return true;
        }

        protected override void ProcessDeclaration(SymbolTable symbolTable)
        {
            List<KeyValuePair<string, TypeExpression>> paramInfo = new List<KeyValuePair<string, TypeExpression>>();
            for (int i = 0; i < Parameters.Count; i++)
                paramInfo.Add(new KeyValuePair<string, TypeExpression>(Parameters[i].Identifier,Parameters[i].FieldType));
            symbolTable.InsertDeclaration(new FunctionSymbol(Identifier, ReturnType, paramInfo));
        }

        protected override void ProcessUndefinedDeclaration(SymbolTable symbolTable)
        {
            symbolTable.InsertDeclaration(new FunctionSymbol(Identifier, null, null));
            symbolTable.InvalidateDeclaration<FunctionSymbol>(Identifier);
        }

        #endregion
    }
}
