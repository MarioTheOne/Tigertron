using System;
using System.Collections.Generic;
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
    public class RecordCostantNode : ConstantValueNode
    {
        #region	Fields and Properties

        public override TypeExpression ReturnType { get; set; }

        private string _typeId;
        private string TypeId { get { return _typeId ?? (_typeId = GetChild(0).Text); } }

        private int FieldsCount { get { return (GetChild(1).ChildCount); } }

        #endregion

        #region	Builder Methods

        public RecordCostantNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            int initErr = errors.Count;
            TypeSymbol type;//Check if TypeId is valid
            if (MappingDeclaration(TypeId, symbolTable, errors, Line, CharPositionInLine, out type))
            {
                //Check is type is record
                if (!(type.TypeExpression.PrimitiveType is RecordType))
                {
                    string message = string.Format("{0} type cannot be converted to an record type", type.TypeExpression);
                    errors.Add(new Error(message, Line, CharPositionInLine));
                }
                else
                {
                    RecordType recordType = type.TypeExpression.PrimitiveType as RecordType;
                    //Check count of fields
                    if (FieldsCount == recordType.Fields.Count)
                    {
                        //Check fields' assignment
                        for (int i = 0; i < FieldsCount; i++)
                        {
                            InstructionNode fieldValue = GetFieldValue(i);
                            string fieldName = GetFieldName(i);
                            bool validField = fieldValue.CheckSemantic(errors, symbolTable);
                            if (recordType.Fields.ContainsKey(fieldName))
                            {
                                if (validField)
                                    CheckAssigment(fieldValue, recordType.Fields[fieldName], errors);
                            }
                            else
                            {
                                string message = string.Format("Type {0} not contain a field with name {1}",
                                                               type.TypeExpression.Identifier, fieldName);
                                errors.Add(new Error(message, Line, CharPositionInLine));
                            }
                        }
                        if (initErr == errors.Count)
                        {
                            Scope = symbolTable.TopScope.Clone();
                            ReturnType = type.TypeExpression;
                            return true;
                        }
                    }
                    else
                    {
                        string message = string.Format("The number of fields of type {0} is {1}",
                                                       type.TypeExpression.Identifier, recordType.Fields.Count);
                        errors.Add(new Error(message, Line, CharPositionInLine));
                    }
                }
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            var recordType = Scope.MappingDeclaration<TypeSymbol>(_typeId).TypeExpression.PrimitiveType as RecordType;

            ConstructorInfo constructor = recordType.ILType.GetConstructor(new Type[]{});
            gen.Emit(OpCodes.Newobj, constructor);
            var recordILType = ReturnType.PrimitiveType.ILType;
            var recordFields = recordILType.GetFields();

            for (int i = 0; i < FieldsCount; i++)
            {
                gen.Emit(OpCodes.Dup);
                GetFieldValue(i).GenCode(cg);
                gen.Emit(OpCodes.Stfld, recordFields[i]);
            }
        }

        #endregion

        #region	Auxiliar Methods

        private InstructionNode GetFieldValue(int i_th)
        {
            var fieldAssignList = GetChild(1);
            var ith_field = fieldAssignList.GetChild(i_th);

            return ith_field.GetChild(1) as InstructionNode;
        }
        private string GetFieldName(int i_th)
        {
            var fieldAssignList = GetChild(1);
            var ith_field = fieldAssignList.GetChild(i_th);

            return ith_field.GetChild(0).Text;
        }

        #endregion
    }
}
