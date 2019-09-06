using System.Collections.Generic;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class RecordAccessNode : AccessInstructionNode,IAssignable
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }

        private string _fieldName;
        public string FieldName
        {
            get { return _fieldName ?? (_fieldName = (GetChild(0).Text)); }
        }

        private bool _isLValue;
        public bool IsLValue
        {
            get { return _isLValue; }
        }

        #endregion

        #region	Builder Methods

        public RecordAccessNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            if (base.CheckSemantic(errors,symbolTable))
            {
                TypeExpression resultType = LValue.ReturnType.ExtractField(FieldName);
                if (resultType is ErrorType)
                    errors.Add(new Error((resultType as ErrorType).Message, Line, CharPositionInLine));
                else _isLValue = (LValue is IAssignable);

                ReturnType = resultType;
            }
            if (initErr == errors.Count)
            {
                Scope = symbolTable.TopScope.Clone();
                return true;
            }
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            LValue.GenCode(cg);
            var expType = LValue.ReturnType.PrimitiveType.ILType;//Obtengo el tipo del LValue 
            var fieldInfo = expType.GetField(FieldName);//Obtengo el tipo del campo
            cg.GetGenerator.Emit(OpCodes.Ldfld, fieldInfo);
        }

        public void AssignValue(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var value = gen.DeclareLocal(ReturnType.PrimitiveType.ILType);
            gen.Emit(OpCodes.Stloc, value);

            //Ponemos losvalores necesarios en la pila
            LValue.GenCode(cg);
            gen.Emit(OpCodes.Ldloc, value);

            var expType = LValue.ReturnType.PrimitiveType.ILType;//Obtengo el tipo del LValue 
            var fieldInfo = expType.GetField(FieldName);//Obtengo el tipo del campo

            gen.Emit(OpCodes.Stfld, fieldInfo);//pongo el valor de la pila en el campo del record
        }

        #endregion
    }
}
