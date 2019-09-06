
using System;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.TypeChecking
{
    public abstract class TypeExpression
    {
        #region	Properties

        /// <summary>
        /// this property defined the name of the TypeExpression 
        /// </summary>
        public string Identifier { get; private set; }

        /// <summary>
        /// this property defined the most basic of source type of the TypeExpression 
        /// </summary>
        public abstract TypeExpression PrimitiveType { get; }

        /// <summary>
        /// specify if a variable of this type allow nil as value
        /// </summary>
        public abstract bool IsNullable { get; }

        /// <summary>
        /// this property specify if type expression is correctly defined
        /// </summary>
        public bool IsDefined { get; set; }


        public virtual Type ILType { get; set; }

        #endregion

        #region	BuilderMethods

        protected TypeExpression(string identifier)
        {
            Identifier = identifier;
            IsDefined = true;
        }

        #endregion

        #region	Main Methods

        /// <summary>
        /// the main objective of this method is equivalenty checking of type expressions
        /// </summary>
        public abstract bool IsEquivalent(TypeExpression otherType);
        
        #region	InferenceType

        /*
         * Summary
         * 
         * The main objective of these methods is calculated or deduce the type expression result of apply a language's operator 
         * 
         */


        /// <summary>
        /// the main objective of this method is calculated or deduce the type expression result of apply operator "[]"
        /// </summary>
        /// <param name="index">index type must be integer and reference an item of collection</param>
        /// <returns>type expression that be storaged in collection </returns>
        public virtual TypeExpression SubscriptAt(TypeExpression index)
        {
            return new ErrorType(string.Format("Invalid operation. Operator \"[]\" is not supported by type {0}", Identifier));
        }

        /// <summary>
        /// the main objective of this method is calculated or deduce the type expression result of apply operator "."
        /// </summary>
        /// <param name="fieldName">name of field referenced</param>
        /// <returns>type expression of referenced field</returns>
        public virtual TypeExpression ExtractField(string fieldName)
        {
            return new ErrorType(string.Format("Invalid operation. Operator \".\" is not supported by type {0}", Identifier));
        }

        #endregion

        public override string ToString()
        {
            return Identifier;
        }

        public virtual void DefineType(ICodeGenerator cg)
        {

        }

        #endregion

        #region	SingletonTypes

        public static readonly IntegerType IntType = new IntegerType();
        public static readonly VoidType VoidType = new VoidType();
        public static readonly StringType StringType = new StringType();
        public static readonly ErrorType ErrorType = new ErrorType();
        public static readonly NilType NilType = new NilType(); 

        #endregion
    }
}
