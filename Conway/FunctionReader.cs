using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;

namespace Conway
{
    public static class FunctionReader
    {
        public static Func<decimal, decimal, decimal> Parse(string input)
        {
            var provider = new CSharpCodeProvider();
            var parameters = new CompilerParameters { GenerateInMemory = true };
            parameters.ReferencedAssemblies.Add("System.dll");

            
            try
            {
                var results = provider.CompileAssemblyFromSource(parameters, $@"
                               using System; 
                               
                               public static class LambdaCreator 
                               {{
                                   public static decimal F(decimal x, decimal y)
                                   {{
                                        {{{input}}}
                                   }}
                               }}");
                var method = results.CompiledAssembly.GetType("LambdaCreator").GetMethod("F");
                return (Func<decimal, decimal, decimal>)Delegate.CreateDelegate(typeof(Func<decimal, decimal, decimal>),null, method);

            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("Input should be valid C# expression", nameof(input));
            }

        }
    }
}
