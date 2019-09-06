using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis;
using TigertronCompiler.SemanticAnalysis.DecoratedAST_Node;
using TigertronCompiler.SymbolTableManagement;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler
{
    public class Compiler
    {
        public static int Main(string[] args)
        {
            InitCompiler();
            if (args.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Compiler need a .TIG file to compile, please drag the file over Tigertron aplication or pass it as parameter in a command line");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n///////////////////////////////////////////////////////////");
                Console.WriteLine("Press [ENTER] key to exit.");
                Console.ReadLine();
                return 1;
            }
            string inputPath = args[0];
            int result = Compile(inputPath, inputPath);
            CloseCompiler();
            
            return result;

        }
        
        private static void InitCompiler()
        {
            Console.Title = "TigertronCompiler";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n\nTigertron Compiler version 1.0.3");
            Console.WriteLine("Copyright (C) 2011-2012 Gustavo Lara & Mario A. Prado\n\n");
        }
        private static void CloseCompiler()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n///////////////////////////////////////////////////////////");
            Console.WriteLine("Press [ENTER] key to exit.");
            Console.ReadLine();
            Console.ResetColor();
        }

        public static int Compile(string inputPath, string outputPath)
        {
            try
            {
                ANTLRFileStream input = new ANTLRFileStream(inputPath);
                //LexicalAnalysis
                TigerLexer lexer = new TigerLexer(input);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);

                //SintaxAnalysis
                TigerParser parser = new TigerParser(tokenStream);//Use tokens obtained by lexer 
                parser.TreeAdaptor = new ASTFactory();//Use my ASTFactory
                TigerParser.tiger_program_return tigerProgram = parser.tiger_program();

                //**Check lexical and sintax errors

                if (lexer.Errors.Count == 0 && parser.Errors.Count == 0)
                {
                    //SemanticAnalysis
                    List<Error> semanticErrors = new List<Error>();
                    SymbolTable symbolTable = new SymbolTable();
                    InstructionNode decoratedExpr = tigerProgram.Tree as InstructionNode;
                    decoratedExpr.CheckSemantic(semanticErrors, symbolTable);
                    if (semanticErrors.Count == 0)
                    {
                        TypeExpression programReturnType = decoratedExpr.ReturnType.PrimitiveType;
                        if (programReturnType is BuiltInType || programReturnType is NilType)
                        {

                            ProgramGenerator.BuildTigerProgram(outputPath, decoratedExpr);
                            return ReportCompilationSuccesful(inputPath);
                        }
                        string message = "If program isn't a valueless expression its return type has to be a built-in type";
                        semanticErrors.Add(new Error(message, decoratedExpr.Line, decoratedExpr.CharPositionInLine));
                    }
                    return ReportCompilationFailed(semanticErrors);
                }
                IEnumerable<Error> antlrErrors = lexer.Errors.Union(parser.Errors);
                return ReportCompilationFailed(antlrErrors);
            }
            catch (Exception e)
            {
                IEnumerable<Error> exeption = new[] { new Error(e.Message, 0, 0, ErrorKind.UserError) };
                return ReportCompilationFailed(exeption);
            }
        }
        static int ReportCompilationFailed(IEnumerable<Error> errors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var error in errors)
                Console.WriteLine(error);
            return 1;
        }
        static int ReportCompilationSuccesful(string inputPath)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Compilation succesful of {0}", Path.GetFileName(inputPath));
            return 0;
        }
    }
}
