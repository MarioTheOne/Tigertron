using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;

namespace TigertronCompiler.IntermediateCodeGeneration
{
    public class StandardLibrary
    {
        private ModuleBuilder moduleBuilder;
        private Dictionary<string, MethodBuilder> usedFunctions;


        public StandardLibrary(ModuleBuilder moduleBuilder)
        {
            this.moduleBuilder = moduleBuilder;
            usedFunctions = new Dictionary<string, MethodBuilder>();
            usedFunctions.Add("print", null);
            usedFunctions.Add("printi", null);
            usedFunctions.Add("flush", null);
            usedFunctions.Add("getchar", null);
            usedFunctions.Add("ord", null);
            usedFunctions.Add("chr", null);
            usedFunctions.Add("size", null);
            usedFunctions.Add("substring", null);
            usedFunctions.Add("concat", null);
            usedFunctions.Add("not", null);
            usedFunctions.Add("exit", null);
            usedFunctions.Add("getline", null);
            usedFunctions.Add("printline", null);
        }

        public bool IsStandardFunction(string name)
        {
            return usedFunctions.ContainsKey(name);
        }

        public void GenerateFunction(ICodeGenerator cg, string name)
        {
            MethodBuilder methodBuilder = null;
            if (usedFunctions[name] == null)
            {

                ILGenerator gen = null;
                var flags = MethodAttributes.Static | MethodAttributes.Public;
                switch (name)
                {
                    case "print":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(void),
                                                                        new[] { typeof(string) });
                            gen = methodBuilder.GetILGenerator();
                            GenPrintFunction(gen);
                            break;
                        }

                    case "printi":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(void),
                                                                        new[] { typeof(int) });
                            gen = methodBuilder.GetILGenerator();
                            GenPrintiFunction(gen);
                            break;
                        }

                    case "flush":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(string),
                                                                        new Type[0]);
                            gen = methodBuilder.GetILGenerator();
                            GenFlushFunction(gen);
                            break;
                        }
                    case "getchar":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(string),
                                                                        new Type[0]);
                            gen = methodBuilder.GetILGenerator();
                            GenGetCharFunction(gen);
                            break;
                        }

                    case "ord":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(int),
                                                                        new[] { typeof(string) });
                            gen = methodBuilder.GetILGenerator();
                            GenOrdFunction(gen);
                            break;
                        }
                    case "chr":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(string),
                                                                        new[] { typeof(int) });
                            gen = methodBuilder.GetILGenerator();
                            GenChrFunction(gen);
                            break;
                        }

                    case "size":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(int),
                                                                        new[] { typeof(string) });
                            gen = methodBuilder.GetILGenerator();
                            GenSizeFunction(gen);
                            break;
                        }

                    case "substring":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(string),
                                                                        new[] { typeof(string), typeof(int), typeof(int) });
                            gen = methodBuilder.GetILGenerator();
                            GenSubstringFunction(gen);
                            break;
                        }

                    case "concat":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(string),
                                                                       new[] { typeof(string), typeof(string) });
                            gen = methodBuilder.GetILGenerator();
                            GenConcatFunction(gen);
                            break;
                        }
                    case "not":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(int),
                                                                       new[] { typeof(int) });
                            gen = methodBuilder.GetILGenerator();
                            GenNotFunction(gen);
                            break;
                        }

                    case "exit":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(void),
                                                                       new[] { typeof(int) });
                            gen = methodBuilder.GetILGenerator();
                            GenExitFunction(gen);
                            break;
                        }

                    case "getline":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(string),
                                                                        new Type[0]);
                            gen = methodBuilder.GetILGenerator();
                            GenGetLineFunction(gen);
                            break;
                        }

                    case "printline":
                        {
                            methodBuilder = cg.TypeBuilder.DefineMethod(name, flags, typeof(void),
                                                                       new[] { typeof(string) });
                            gen = methodBuilder.GetILGenerator();
                            GenPrintLineFunction(gen);
                            break;
                        }
                }
                usedFunctions[name] = methodBuilder;
            }
            
            cg.GetGenerator.Emit(OpCodes.Call, usedFunctions[name]);
        }

        #region Function Bodies

        public void GenPrintFunction(ILGenerator gen)
        {
            MethodInfo writeMethod = typeof(Console).GetMethod("Write", new[] { typeof(string) });
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Call, writeMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenPrintiFunction(ILGenerator gen)
        {
            MethodInfo writeMethod = typeof(Console).GetMethod("Write", new[] { typeof(int) });
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Call, writeMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenFlushFunction(ILGenerator gen)
        {
            //Obtenemos la instancia de TextWriter de la clase Console
            PropertyInfo p = typeof(Console).GetProperty("Out");
            gen.Emit(OpCodes.Call, p.GetGetMethod());

            //Llamamos el metodo flush de esa instancia de TextWriter
            MethodInfo flushMethod = typeof(TextWriter).GetMethod("Flush", new Type[] { });
            gen.Emit(OpCodes.Callvirt, flushMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenGetCharFunction(ILGenerator gen)
        {
            var noCharReadedLabel = gen.DefineLabel();//etiqueta para marcar que el Read devolvio -1
            var endLabel = gen.DefineLabel();//etiqueta para marcar el fin de la funcion

            MethodInfo readMethod = typeof(Console).GetMethod("Read");
            gen.Emit(OpCodes.Call, readMethod);//Llamamos a Console.Read

            gen.Emit(OpCodes.Dup);//ponemos el valor duplicado en la pila para usar la copia en la comparacion
            gen.Emit(OpCodes.Ldc_I4_M1);//Colocamos -1 en la pila para compararlo con el resultado del read

            gen.Emit(OpCodes.Beq, noCharReadedLabel);//Comparamos -1 con la copia del resultado de Read

            MethodInfo convertFromUtf32Method = typeof(Char).GetMethod("ConvertFromUtf32", new[] { typeof(int) });
            gen.Emit(OpCodes.Call, convertFromUtf32Method);//Llamamos a Char.ConvertFromUtf32 que nos da un char dado un int
            gen.Emit(OpCodes.Br, endLabel);//Saltamos al final de la funcion

            gen.MarkLabel(noCharReadedLabel);//Ponemos la etiqueta noCharReaded
            gen.Emit(OpCodes.Pop);//Sacamos el -1 de la pila
            gen.Emit(OpCodes.Ldstr, "");//ponemos la cadena vacia en la pila

            gen.MarkLabel(endLabel);//Etiqueta del fin de la funcion
            gen.Emit(OpCodes.Ret);

        }

        public void GenOrdFunction(ILGenerator gen)
        {
            var emptyStringLabel = gen.DefineLabel();
            var endLabel = gen.DefineLabel();

            //Verificamos si es la cadena vacia
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldstr, "");
            gen.Emit(OpCodes.Beq, emptyStringLabel);

            //Si no es la cadena vacia
            //Obtenemos el char de la primera posicion
            MethodInfo getCharsMethod = typeof(string).GetMethod("get_Chars", new[] { typeof(int) });
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Call, getCharsMethod);

            //Convertimos el char a int
            MethodInfo toInt32Method = typeof(Convert).GetMethod("ToInt32", new[] { typeof(char) });
            gen.Emit(OpCodes.Call, toInt32Method);
            gen.Emit(OpCodes.Br, endLabel);

            //Si la cadena es vacia
            gen.MarkLabel(emptyStringLabel);
            gen.Emit(OpCodes.Ldc_I4_M1);

            gen.MarkLabel(endLabel);
            gen.Emit(OpCodes.Ret);
        }

        public void GenChrFunction(ILGenerator gen)
        {
            gen.Emit(OpCodes.Ldarg_0);
            var convertFromUtf32Method = typeof(Char).GetMethod("ConvertFromUtf32");
            gen.Emit(OpCodes.Call, convertFromUtf32Method);
            gen.Emit(OpCodes.Ret);
        }

        public void GenSizeFunction(ILGenerator gen)
        {
            gen.Emit(OpCodes.Ldarg_0);
            var lengthMethod = typeof(string).GetMethod("get_Length");
            gen.Emit(OpCodes.Call, lengthMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenSubstringFunction(ILGenerator gen)
        {
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Ldarg_2);
            var substringMethod = typeof(string).GetMethod("Substring", new[] { typeof(int), typeof(int) });
            gen.Emit(OpCodes.Call, substringMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenConcatFunction(ILGenerator gen)
        {
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            var concatMethod = typeof(string).GetMethod("Concat", new[] { typeof(string), typeof(string) });
            gen.Emit(OpCodes.Call, concatMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenNotFunction(ILGenerator gen)
        {
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Ceq);
            gen.Emit(OpCodes.Ret);
        }

        public void GenExitFunction(ILGenerator gen)
        {
            gen.Emit(OpCodes.Ldarg_0);
            var exitMethod = typeof(Environment).GetMethod("Exit", new[] { typeof(int) });
            gen.Emit(OpCodes.Call, exitMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenGetLineFunction(ILGenerator gen)
        {
            var readLineMethod = typeof(Console).GetMethod("ReadLine");
            gen.Emit(OpCodes.Call, readLineMethod);
            gen.Emit(OpCodes.Ret);
        }

        public void GenPrintLineFunction(ILGenerator gen)
        {
            var writeLineMethod = typeof(Console).GetMethod("WriteLine", new[] { typeof(string) });
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Call, writeLineMethod);
            gen.Emit(OpCodes.Ret);
        }

        #endregion Function Bodies
    }
}
