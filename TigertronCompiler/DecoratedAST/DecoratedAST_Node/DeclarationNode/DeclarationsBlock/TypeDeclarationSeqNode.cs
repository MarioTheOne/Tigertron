using System.Collections.Generic;
using System.Linq;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class TypeDeclarationSeqNode : RecursiveDeclarationSeqNode
    {
        
        #region	Fields and Properties

        #endregion

        #region	Builder Methods

        public TypeDeclarationSeqNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable)   
        {
            int initErr = errors.Count;
            Dictionary<string, string> subyacentTypes = new Dictionary<string, string>();
            Dictionary<string, KeyValuePair<int, int>> errorPos = new Dictionary<string, KeyValuePair<int, int>>();
            foreach (var typeDeclaration in Declarations.Where//guardo solo los de tipo array y alias
                (typeDeclaration => typeDeclaration.CheckHeaderSemantic(errors,symbolTable) && 
                (typeDeclaration is AliasDeclarationNode || typeDeclaration is ArrayDeclarationNode)))
            {
                int line = typeDeclaration.Line, col = typeDeclaration.CharPositionInLine;
                subyacentTypes.Add(typeDeclaration.Identifier, typeDeclaration.GetChild(1).Text);
                errorPos.Add(typeDeclaration.Identifier, new KeyValuePair<int, int>(line,col));
            }
            CheckCyclicDependencies(subyacentTypes, errors, errorPos, symbolTable);
            return initErr == errors.Count;
        }

        #endregion

        #region	Auxiliar Method
        
        /*
         * SUMMARY
         * No esta permitido que una declaracion de tipos mutuamente recursivos este solamente formada por 
         * alias o arrays, es decir solo es valida si al menos uno de ellos es un record
         * 
         * luego basta con comprobar que no existan ciclos entre los alias y arrays (que estan definidos en el bloque)
         * que seran los unicos que tengo en el dictionary types. 
         * 
         * estos metodos detectan ciclos de manera similar que un dfs
         * 
         */
        void CheckCyclicDependencies(Dictionary<string,string> subyacentType, List<Error> errors,Dictionary<string,KeyValuePair<int,int>> errorPos, SymbolTable symbolTable)
        {
            Dictionary<string, bool> visitRecord = subyacentType.ToDictionary(kvp => kvp.Key, kvp => false);
            foreach (var kvp in subyacentType.Where(kvp => !visitRecord[kvp.Key]))//busco que no lo haya visitado antes
            {
                Dictionary<string, string> currentPath = new Dictionary<string, string>();
                string sourceCycle = ExploreType(kvp.Key, visitRecord, currentPath, subyacentType);
                if (sourceCycle != null)
                    ReportCycle(currentPath, sourceCycle, errors,errorPos,symbolTable);
                //marco como visitados los del ultimo camino, para saber que a partir de ahi no se llega a un ciclo
                foreach (var step in currentPath)
                    visitRecord[step.Key] = true;
            }
        }
        //devuelve el identificador de la raiz del ciclo
        private string ExploreType(string typeId, Dictionary<string, bool> visitRecord, Dictionary<string, string> currentPath, 
                                    Dictionary<string,string> subyacentType)
        {
            if (!visitRecord.ContainsKey(typeId) || visitRecord[typeId])
                return null;//ya lo visite y se que a partir de el no hay ciclos, o ese tipo no esta en el bloque, o no es de tipo array o alias

            //entonces esta en el diccionario y no se ha usado
            if (currentPath.ContainsKey(typeId))
                return typeId; //significa que habia llegado a el en otro momento
            string nextStep = subyacentType[typeId];//me dira cual sera el proximo tipo a analizar
            currentPath.Add(typeId, nextStep);
            return ExploreType(nextStep, visitRecord, currentPath,subyacentType);
        }
        private void ReportCycle(Dictionary<string, string> currentPath, string sourceCycle, List<Error> errors, 
                                    Dictionary<string, KeyValuePair<int, int>> errorPos, SymbolTable symbolTable)
        {
            string cycle = sourceCycle;
            string nextStep = sourceCycle;
            do
            {
                symbolTable.InvalidateDeclaration<TypeSymbol>(nextStep);
                nextStep = currentPath[nextStep];
                cycle += "->" + nextStep;
            } while (nextStep != sourceCycle);

            string message = "Each recursion cycle must pass through a record type. Invalid cycle:[" + cycle + "]";
            errors.Add(new Error(message, errorPos[sourceCycle].Key, errorPos[sourceCycle].Value));
        }

        #endregion
    }
}
