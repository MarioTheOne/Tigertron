using System;
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
    public class FunctionCallNode : InstructionNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }

        public string FunctionName { get { return GetChild(0).Text; } }

        private List<InstructionNode> _parameters;
        public List<InstructionNode> Parameters
        {
            get
            {
                if (_parameters == null)
                {
                    _parameters = new List<InstructionNode>();
                    var paramSeq = GetChild(1);
                    for (int i = 0; i < paramSeq.ChildCount; i++)
                        _parameters.Add(paramSeq.GetChild(i) as InstructionNode);
                }
                return _parameters;
            }
        }

        #endregion

        #region	Builder Methods

        public FunctionCallNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            StatementSymbol symbol;
            if (MappingDeclaration(FunctionName, symbolTable, errors, Line, CharPositionInLine, out symbol))
            {
                if (symbol is FunctionSymbol)
                {
                    FunctionSymbol functionSymbol = symbol as FunctionSymbol;
                    if (Parameters.Count != functionSymbol.Params.Count)//Check count of params
                    {
                        string message = string.Format("No definition for function '{0}'  takes '{1}' arguments", FunctionName, Parameters.Count);
                        errors.Add(new Error(message, Line, CharPositionInLine));
                    }
                    else//Check params assigment
                    {
                        for (int i = 0; i < Parameters.Count; i++)
                            if (Parameters[i].CheckSemantic(errors, symbolTable))
                            {
                                var paramInfo = functionSymbol.Params[i];
                                string decMessage = string.Format("{0}-th param ({1}:{2}) is mismatched", i + 1, paramInfo.Key, paramInfo.Value);
                                CheckAssigment(Parameters[i], paramInfo.Value, errors, decMessage);
                            }

                    }
                    if (initErr == errors.Count)
                    {
                        Scope = symbolTable.TopScope.Clone();
                        ReturnType = functionSymbol.ReturnType;
                        return true;
                    }
                }
                else
                {
                    string message = string.Format("'{0}' is a variable but is used like a function", FunctionName);
                    errors.Add(new Error(message, Line, CharPositionInLine));
                }
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            if (!cg.GetStandardLibrary.IsStandardFunction(FunctionName))
            {
                FunctionSymbol function = Scope.MappingDeclaration<FunctionSymbol>(FunctionName);

                //Si la funcion todavia no ha sido declarada la declaramos
                if (function.MethodBuilder == null)
                {
                    var fParams = new List<Type>();
                    foreach (var parameter in function.Params)
                    {
                        fParams.Add(parameter.Value.PrimitiveType.ILType);
                    }
                    MethodBuilder functionBld = cg.TypeBuilder.DefineMethod(function.Identifier + "_" + Scope.Id, MethodAttributes.Public | MethodAttributes.Static,
                                                                ReturnType.PrimitiveType.ILType, fParams.ToArray());
                    function.MethodBuilder = functionBld;

                    var fieldAttr = FieldAttributes.Public | FieldAttributes.Static;

                    List<FieldBuilder> paramGlobals = function.Params.Select(t => cg.TypeBuilder.DefineField(t.Key + "_" + function.BodyScopeId, t.Value.PrimitiveType.ILType, fieldAttr)).ToList();
                    function.ParameterFieldBuilders = paramGlobals;

                }

                //Guardo el estado actual de los parametros
                List<LocalBuilder> localParams = new List<LocalBuilder>(function.ParameterFieldBuilders.Count);
                var gen = cg.GetGenerator;
                for (int i = 0; i < function.ParameterFieldBuilders.Count; i++)
                {
                    localParams.Add(gen.DeclareLocal(function.Params[i].Value.PrimitiveType.ILType));
                    gen.Emit(OpCodes.Ldsfld, function.ParameterFieldBuilders[i]);
                    
                    gen.Emit(OpCodes.Stloc, localParams[i]);
                }

                //obtenemos todas las variables declaradas entre el llamado a la funcion y la declaracion de la misma
                var globalVars = GetFieldSymbolsUntilFunctionDeclaration(Scope, function);
                List<LocalBuilder> localVars = new List<LocalBuilder>(globalVars.Count);

                ////Guardamos los valores de estas variables globales en variables locales
                for (int i = 0; i < globalVars.Count; i++)
                {
                    localVars.Add(gen.DeclareLocal(globalVars[i].FieldBuilder.FieldType));
                    gen.Emit(OpCodes.Ldsfld, globalVars[i].FieldBuilder);
                    gen.Emit(OpCodes.Stloc, localVars[i]);
                }

                //Generamos los parametros y guardamos sus valores en las variables locales de intercambio para evitar problemas con los intercambios de parametros
                List<LocalBuilder> interchangeLocalParams = new List<LocalBuilder>();
                for (int i = 0; i < function.ParameterFieldBuilders.Count; i++)
                {
                    interchangeLocalParams.Add(gen.DeclareLocal(function.Params[i].Value.PrimitiveType.ILType));
                    Parameters[i].GenCode(cg);
                    gen.Emit(OpCodes.Dup);
                    gen.Emit(OpCodes.Stloc, interchangeLocalParams[i]);
                }

                //Guardamos en los fields los valores de las variables locales de intercambio
                for (int i = 0; i < interchangeLocalParams.Count; i++)
                {
                    gen.Emit(OpCodes.Ldloc, interchangeLocalParams[i]);
                    gen.Emit(OpCodes.Stsfld, function.ParameterFieldBuilders[i]);
                }

                //LLamado a la funcion
                gen.Emit(OpCodes.Call, function.MethodBuilder);

                //Restablecer el estado de los parametros
                for (int i = 0; i < function.ParameterFieldBuilders.Count; i++)
                {
                    gen.Emit(OpCodes.Ldloc, localParams[i]);
                    gen.Emit(OpCodes.Stsfld, function.ParameterFieldBuilders[i]);
                }


                //Restablecemos el estado de las variables declaradas entre el llamado a la funcion y la declaracion de la misma
                for (int i = 0; i < globalVars.Count; i++)
                {
                    gen.Emit(OpCodes.Ldloc, localVars[i]);
                    gen.Emit(OpCodes.Stsfld, globalVars[i].FieldBuilder);
                }
            }
            else
            {
                foreach (var parameter in Parameters)
                {
                    parameter.GenCode(cg);
                }
                cg.GetStandardLibrary.GenerateFunction(cg, FunctionName);
            }
        }

        #endregion

        #region Auxiliar Methods

        private List<FieldSymbol> GetFieldSymbolsUntilFunctionDeclaration(Scope scope, FunctionSymbol function)
        {
            List<FieldSymbol> result = new List<FieldSymbol>();
            Scope currentScope = Scope;
            bool noFunctionFounded = true;

            while (noFunctionFounded)
            {
                List<FieldSymbol> currentScopeFields = new List<FieldSymbol>();
                foreach (var declaration in currentScope.LocalDeclarations)
                {
                    if (declaration is FieldSymbol)
                    {
                        currentScopeFields.Add(declaration as FieldSymbol);
                    }
                    if (declaration is FunctionSymbol && (declaration.Identifier == function.Identifier))
                    {
                        noFunctionFounded = false;
                        currentScopeFields.Clear();
                        break;
                    }
                }
                result.AddRange(currentScopeFields);
                currentScope = currentScope.Outer;
            }
            return result;
        }

        #endregion Auxiliar Methods
    }
}
