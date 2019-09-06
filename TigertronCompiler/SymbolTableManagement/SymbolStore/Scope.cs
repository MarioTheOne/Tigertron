using System.Collections.Generic;
using System.Linq;
using TigertronCompiler.SymbolTableManagement.SymbolNode;

namespace TigertronCompiler.SymbolTableManagement.SymbolStore
{
    /// <summary>
    /// Range in wich declared names are valid
    /// </summary>
    public class Scope
    {
        #region	Fields and Properties

        public long Id { get; set; }
        
        /// <summary>
        /// This property reference to parent of this scope
        /// </summary>
        public Scope Outer { get; set; }

        /// <summary>
        /// Declarations in this scope
        /// </summary>
        public List<Symbol> LocalDeclarations { get; private set; }

        /// <summary>
        /// this property specify the type of this scope
        /// </summary>
        public ScopeType ScopeType { get; private set; }

        #endregion

        #region	Builder Methods

        public Scope(ScopeType type, long identifier)
        {
            ScopeType = type;
            LocalDeclarations = new List<Symbol>();
            Id = identifier;
        }

        #endregion

        #region	Main Methods

        public Scope Clone()
        {
            Scope clone = new Scope(ScopeType,Id);
            clone.LocalDeclarations = new List<Symbol>(LocalDeclarations);
            clone.Outer = Outer;
            return clone;
        }

        /// <summary>
        /// this method does a deep search in program of a T-declaration with identifier specified
        /// </summary>
        /// <typeparam name="T">specify declaration type</typeparam>
        /// <param name="identifier">specify declaration identifier</param>
        /// <returns></returns>
        public T MappingDeclaration<T>(string identifier)
            where T : Symbol
        {
            T localDeclaration = SearchLocalDeclaration<T>(identifier);
            if (localDeclaration != null) return localDeclaration;
            return Outer == null ? null : Outer.MappingDeclaration<T>(identifier);
        }

        public void InsertDeclaration(Symbol declaration)
        {
            //previously was be checked that in each namespace
            //there not be two declarations with the same identifier 
            LocalDeclarations.Add(declaration);
        }

        public T SearchLocalDeclaration<T>(string identifier)
            where T : Symbol
        {
            foreach (var declaration in LocalDeclarations.OfType<T>())
                if (declaration.Identifier == identifier)
                    return declaration;
            return null;
        }

        public bool IsThereParam(string identifier, out FieldSymbol param)
        {
            param = null;
            FieldSymbol localField = SearchLocalDeclaration<FieldSymbol>(identifier);
            if (localField != null)//hay una variable local definida
            {
                //no es una funcion y si hubiera un parametro "identifier" entonces localField lo ocultaria 
                if (ScopeType != ScopeType.Function) return false;
                //si llega aqui, hay un parametro de nombre identifier visible para nuestro scope 
                param = localField;
                return true;
            }
            return Outer != null && Outer.IsThereParam(identifier, out param);
        }

        #endregion

        #region	Auxiliar Methods

        

        #endregion
    }

    public enum ScopeType { Program, Let, Function, Loop }
}
