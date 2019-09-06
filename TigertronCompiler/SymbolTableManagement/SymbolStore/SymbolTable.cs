using System.Collections.Generic;
using System.Linq;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;

namespace TigertronCompiler.SymbolTableManagement.SymbolStore
{
    /// <summary>
    /// This class store all declared names and their attributes
    /// </summary>
    public class SymbolTable
    {
        #region	Fields and Properties

        private long _Id;//identifica univocamente cada scope

        private static List<Symbol> _universe;
        /// <summary>
        /// This property store built-in types and standard library
        /// </summary>
        public static List<Symbol> Universe
        {
            get
            {
                if (_universe == null)
                {
                    _universe = new List<Symbol>();


                    //Built-In Types
                    Universe.Add(new TypeSymbol(TypeExpression.StringType));
                    Universe.Add(new TypeSymbol(TypeExpression.IntType));
                    //Note: no incluyo al void porque el se puede sobreescribir

                    //Standard Library

                    #region	print

                    Universe.Add(new FunctionSymbol("print", TypeExpression.VoidType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("s",
                                                                                                     TypeExpression.
                                                                                                         StringType)
                                                        }));

                    #endregion

                    #region	printi

                    Universe.Add(new FunctionSymbol("printi", TypeExpression.VoidType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("i",
                                                                                                     TypeExpression.
                                                                                                         IntType)
                                                        }));

                    #endregion

                    #region	flush

                    Universe.Add(new FunctionSymbol("flush", TypeExpression.VoidType,
                                                    new List<KeyValuePair<string, TypeExpression>>()));

                    #endregion

                    #region	getchar

                    Universe.Add(new FunctionSymbol("getchar", TypeExpression.StringType,
                                                    new List<KeyValuePair<string, TypeExpression>>()));

                    #endregion

                    #region	ord

                    Universe.Add(new FunctionSymbol("ord", TypeExpression.IntType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("s",
                                                                                                     TypeExpression.
                                                                                                         StringType)
                                                        }));

                    #endregion

                    #region	chr

                    Universe.Add(new FunctionSymbol("chr", TypeExpression.StringType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("i",
                                                                                                     TypeExpression.
                                                                                                         IntType)
                                                        }));

                    #endregion

                    #region	size

                    Universe.Add(new FunctionSymbol("size", TypeExpression.IntType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("s",
                                                                                                     TypeExpression.
                                                                                                         StringType)
                                                        }));

                    #endregion

                    #region	substring

                    Universe.Add(new FunctionSymbol("substring", TypeExpression.StringType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("s",
                                                                                                     TypeExpression.
                                                                                                         StringType),
                                                            new KeyValuePair<string, TypeExpression>("f",
                                                                                                     TypeExpression.
                                                                                                         IntType),
                                                            new KeyValuePair<string, TypeExpression>("n",
                                                                                                     TypeExpression.
                                                                                                         IntType)
                                                        }));

                    #endregion

                    #region	concat

                    Universe.Add(new FunctionSymbol("concat", TypeExpression.StringType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("s1",
                                                                                                     TypeExpression.
                                                                                                         StringType),
                                                            new KeyValuePair<string, TypeExpression>("s2",
                                                                                                     TypeExpression.
                                                                                                         StringType)
                                                        }));

                    #endregion

                    #region	not

                    Universe.Add(new FunctionSymbol("not", TypeExpression.IntType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("i",
                                                                                                     TypeExpression.
                                                                                                         IntType)
                                                        }));

                    #endregion

                    #region	exit

                    Universe.Add(new FunctionSymbol("exit", TypeExpression.VoidType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("i",
                                                                                                     TypeExpression.
                                                                                                         IntType)
                                                        }));

                    #endregion

                    //proyect specifications
                    #region	getline

                    Universe.Add(new FunctionSymbol("getline", TypeExpression.StringType,
                                                    new List<KeyValuePair<string, TypeExpression>>()));

                    #endregion

                    #region	printline

                    Universe.Add(new FunctionSymbol("printline", TypeExpression.VoidType,
                                                    new List<KeyValuePair<string, TypeExpression>>
                                                        {
                                                            new KeyValuePair<string, TypeExpression>("s",
                                                                                                     TypeExpression.
                                                                                                         StringType)
                                                        }));

                    #endregion
                }
                return _universe;
            }
        }

        /// <summary>
        /// this property is the current scope
        /// </summary>
        public Scope TopScope { get; set; }

        #endregion

        #region	Builder Method

        public SymbolTable()
        {
            OpenScope(ScopeType.Program);//Init main scope
        }

        #endregion

        #region	Main Methods

        #region	Scope Handling

        public void OpenScope(ScopeType scopeType)
        {
            Scope scope = new Scope(scopeType, _Id++);
            scope.Outer = TopScope;
            TopScope = scope;
        }
        public void CloseScope()
        {
            TopScope = TopScope.Outer;
        }

        #endregion

        #region	Symbol Handling

        /// <summary>
        /// insert a symbol in symbol table
        /// </summary>
        /// <param name="declaration">declaration to insert in symbol table</param>
        /// <returns>return true if is valid, false in other case</returns>
        public void InsertDeclaration(Symbol declaration)
        {
            TopScope.InsertDeclaration(declaration);
        }

        public void InvalidateDeclaration<T>(string identifier)where T:Symbol
        {
            T undefined = MappingDeclaration<T>(identifier);
            undefined.IsDefined = false;
        }

        /// <summary>
        /// obtain attributes of symbol specified by identifier
        /// </summary>
        /// <typeparam name="T">May be a TypeDeclarationNode or FunctionDeclarationNode or VarDeclarationNode</typeparam>
        /// <param name="identifier">identifier of symbol</param>
        /// <returns>if exist a declaration of type T, return it, in other case return null</returns>
        public T MappingDeclaration<T>(string identifier)
            where T : Symbol
        {
            //verify if identifier reference to an Universe's symbol
            T universeDecl = GetUniverseDeclaration<T>(identifier);
            return universeDecl ?? TopScope.MappingDeclaration<T>(identifier);
        }

        /// <summary>
        /// obtain a universal declaration referenced by identifier
        /// </summary>
        /// <typeparam name="T">Tipe of symbol</typeparam>
        /// <param name="identifier">identifier of declaration</param>
        /// <returns>if exist an universe T-declaration return it, null in other case</returns>
        public T GetUniverseDeclaration<T>(string identifier)
            where T : Symbol
        {
            foreach (var symbol in Universe.OfType<T>())
                if (symbol.Identifier == identifier)
                    return symbol;
            return null;
        }

        /// <summary>
        /// obtain a local declaration referenced by identifier
        /// </summary>
        /// <typeparam name="T">Tipe of symbol</typeparam>
        /// <param name="identifier">identifier of declaration</param>
        /// <returns>if exist an local T-declaration return it, null in other case</returns>
        public T GetLocalDeclaration<T>(string identifier) 
            where T : Symbol
        {
            return TopScope.SearchLocalDeclaration<T>(identifier);
        }

        public bool IsThereIterationVar(string identifier)
        {
            var otherVar = MappingDeclaration<FieldSymbol>(identifier);
            return otherVar != null && otherVar.IsReadOnly;//Note: las que declaro como readOnly 
        }

        #endregion

        #endregion
    }
}
