using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using TigertronCompiler.IntermediateCodeGeneration;


namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public class RecordType : CompositeType
    {
        #region	Properties

        public Dictionary<string, TypeExpression> Fields { get; private set; }
        public override TypeExpression PrimitiveType
        {
            get
            {
                return this;
            }
        }
        public override bool IsNullable
        {
            get { return true; }
        }

        #endregion

        #region	BuilderMethod

        public RecordType(string identifier, Dictionary<string, TypeExpression> fields, long scopeId)
            : base(identifier, TypeConstructor.Record,scopeId)
        {
            Fields = fields;
        }

        #endregion
        
        #region	MainMethods

        public override TypeExpression ExtractField(string fieldName)
        {
            if (Fields.ContainsKey(fieldName))
                return Fields[fieldName];
            return new ErrorType(string.Format("There not be a field with name '{0}' in {1}", fieldName, Identifier));
        }

        public override string ToString()
        {
            string result = Identifier;
            result += ": Record{ ";
            foreach (var kvp in Fields)
                result += string.Format("({0} : {1}) ", kvp.Key, kvp.Value.Identifier);
            result += "}";

            return result;
        }

        public override void DefineType(ICodeGenerator cg)
        {
            TypeBuilder tb = cg.Module.DefineType(Identifier + "_" + ScopeId, TypeAttributes.Public | TypeAttributes.Class);
            ILType = tb;
            FieldBuilder[] fldBuilders = new FieldBuilder[Fields.Count];
            Type[] fldTypes = new Type[Fields.Count];

            var fieldsToArr = Fields.ToArray();
            for (int i = 0; i < fieldsToArr.Length; i++)
            {
                var field = fieldsToArr[i];
                if (field.Value.ILType == null) field.Value.DefineType(cg);
                fldTypes[i] = field.Value.ILType;
                fldBuilders[i] = tb.DefineField(field.Key, fldTypes[i], FieldAttributes.Public);
            }
            tb.CreateType();
        }

        #endregion


    }
}
