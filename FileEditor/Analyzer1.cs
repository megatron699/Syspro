using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicDLL
{
    public class Analyzer1: IAnalyzer
    {
        string codeStart = "using System;\n" + 
                           "namespace AnalyzeCode\n" + 
                           "{\n\tpublic static class AnalyzerClass\n" + 
                           "\t{\n" +
                           "\t\tpublic static int AnalyzeMethod()\n" + 
                           "\t\t{";
        string programCodeEnd = "\t\t\treturn countOfWhileRepeat;\n" + 
                                "\t\t}\n" + 
                                "\t}\n" + 
                                "}";

        public string AnalyzerResult { get; set; }
        public string Analyze(string lines)
        {
            var compiler = CodeDomProvider.CreateProvider("CSharp");
            var parametres = new CompilerParameters
            {
                GenerateInMemory = true,
                IncludeDebugInformation = false
            };
            int lastIndex = lines.LastIndexOf("}");
            string whileCycle = lines.Substring(0, lastIndex);
            string countOfWhileRepeatString = "\ncountOfWhileRepeat++;\n}";
            string whileCycleWithInc = whileCycle + countOfWhileRepeatString;
            string resultOfWhileCycle = whileCycleWithInc + lines.Substring(lastIndex + 1);
            string sourceCode = codeStart + "\nint countOfWhileRepeat=0;\n" + resultOfWhileCycle + programCodeEnd;
            CompilerResults results = compiler.CompileAssemblyFromSource(parametres, sourceCode);
            if (results.Errors.Capacity > 0) AnalyzerResult = results.Errors.ToString();
            object repeatCount = null;
            Type type = compiler.GetType();
            object obj = Activator.CreateInstance(type);
            Thread compileThread = new Thread(() =>
            {
                repeatCount = results.CompiledAssembly.GetType("LogicDLL.Analyzer1").GetMethod("Check").Invoke(obj, new object[] { lines });
            });
            compileThread.Start();
            
            return AnalyzerResult;
        }
        public string Check(string lines)
        {
            int position = 0;
            bool isWhile = false;
            int positionStartCycle;
            int inputStructureLength = lines.Length;
            do
            {
                positionStartCycle = lines.IndexOf("while", position);

                if (positionStartCycle == -1) return AnalyzerResult="Ошибка во входной строке";

                if (positionStartCycle == 0)
                {
                    if (inputStructureLength > 5 && !char.IsLetterOrDigit(lines[5]))
                    {
                        isWhile = true;
                        break;
                    }
                }
                else AnalyzerResult = "Ошибка во входной строке";

                if (positionStartCycle + 1 < inputStructureLength)
                {
                    var prevChar = lines[positionStartCycle - 1];
                    var nextChar = lines[positionStartCycle + 7];

                    if (!char.IsLetterOrDigit(prevChar) && prevChar != '/' && !char.IsLetterOrDigit(nextChar))
                    {
                        isWhile = true;
                        break;
                    }
                }
                else AnalyzerResult = "Ошибка во входной строке";
                position = positionStartCycle;

            } while (position < lines.Length && position != -1);

            int countQuotes = 0;
            if (isWhile)
            {
                int i = positionStartCycle;
                int positionEndCycle = lines.LastIndexOf('}') + 1;

                while (i < positionEndCycle)
                {
                    char curChar = lines[i];
                    if (curChar == '{')
                        countQuotes++;
                    else if (curChar == '}')
                        countQuotes--;
                    i++;
                }
                AnalyzerResult = "Цикл выполнится хотя бы один раз";
            }
            
            if (countQuotes != 0 || position >= lines.Length || position == -1)
                 AnalyzerResult = "Цикл не содержит WHile";
            return AnalyzerResult;     
        }
    }
}
