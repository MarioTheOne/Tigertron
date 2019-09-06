using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.DecoratedAST_Node;
using TigertronCompiler.SemanticAnalysis.TypeChecking;

namespace TigertronCompiler
{
    static class ProgramGenerator
    {
        public static void BuildTigerProgram(string output, InstructionNode programExp)
        {
            string fileName = Path.GetFileNameWithoutExtension(output);
            string exeName = fileName + ".exe";
            //Definimos el nombre del ensamblado
            AssemblyName assemblyName = new AssemblyName(fileName);

            //Creamos un assemblyBuilder con el nombre del ensamblado deseado y en modo save 
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave, Path.GetDirectoryName(output));
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(fileName, exeName);
            TypeBuilder typeBuilder = moduleBuilder.DefineType("TigerProgram", TypeAttributes.Public | TypeAttributes.Class);
            MethodBuilder methodBuilder = typeBuilder.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static, typeof(int), new Type[0]);


            StandardLibrary stdlib = new StandardLibrary(moduleBuilder);
            ILGenerator gen = methodBuilder.GetILGenerator();

            ILCodeGenerator cg = new ILCodeGenerator(moduleBuilder, typeBuilder, gen, stdlib);


            var result = gen.DeclareLocal(typeof(int));

            //asigno 0 a result
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Stloc, result);

            // Begin the try block.
            gen.BeginExceptionBlock();

            programExp.GenCode(cg);
            if (!(programExp.ReturnType is VoidType))//saco el resultado de la pila
                gen.Emit(OpCodes.Pop);

            // Start the catch block for any Exception
            gen.BeginCatchBlock(typeof(Exception));
            PropertyInfo message = typeof(Exception).GetProperty("Message");
            MethodInfo getMessage = message.GetGetMethod();
            gen.Emit(OpCodes.Callvirt, getMessage);
            MethodInfo writeLine = typeof(Console).GetMethod("WriteLine", new[] { typeof(string) });
            gen.Emit(OpCodes.Call, writeLine);
            MethodInfo readLine = typeof(Console).GetMethod("ReadLine");
            gen.Emit(OpCodes.Call, readLine);
            gen.Emit(OpCodes.Pop);

            //pongo 1 en result
            gen.Emit(OpCodes.Ldc_I4_1);
            gen.Emit(OpCodes.Stloc, result);

            gen.EndExceptionBlock();

            //en result estara el codigo de salida
            gen.Emit(OpCodes.Ldloc, result);
            gen.Emit(OpCodes.Ret);
            typeBuilder.CreateType();
            assemblyBuilder.SetEntryPoint(methodBuilder);
            assemblyBuilder.Save(exeName);
        }
    }
}
