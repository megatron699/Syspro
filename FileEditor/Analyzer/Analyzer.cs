using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDLL
{
    public class Analyzer 
    {
       
        private  Dictionary<string, int> values;
        private readonly List<char> listSigns;
        public Analyzer()
        {
            values = new Dictionary<string, int>();
            listSigns = new List<char>()
            {
            '<','>','!','=','|','&'
            };
        }
        
        public string AnalyzerResult { get; set; }

        private string ReturnSign(ref int index, string str)
        {
            while (index < str.Length && !listSigns.Contains(str[index])) index++;

            var startIndex = index;

            while (index < str.Length && listSigns.Contains(str[index])) index++;

            return str.Substring(startIndex, index - startIndex);
        }

        private int ReturnDigit(ref int index, string str)
        {
            var startIndex = index;

            while (index < str.Length && char.IsDigit(str[index])) index++;

            return int.Parse(str.Substring(startIndex, index - startIndex));
        }

        private string ReturnVariable(ref int index, string str)
        {
            int startIndex = index;

            while (index < str.Length && (char.IsLetter(str[index]) || char.IsDigit(str[index]))) index++;

            string variables = string.Empty;

            variables = str.Substring(startIndex, index - startIndex);

            return variables;
        }

        private string BooleanResult(string value1, string value2, string sign)
        {
            int first = 0;
            int second = 0;

            bool firstBool = false, secondBool = false;

            try
            {
                first = values.ContainsKey(value1) ? values[value1] : int.Parse(value1); ;
                second = values.ContainsKey(value2) ? values[value2] : int.Parse(value2); ;
            }
            catch
            {
                bool.TryParse(value1, out firstBool);
                bool.TryParse(value2, out secondBool);
            }

            switch (sign)
            {
                case ">":
                    return first > second ? "true" : "false";

                case ">=":
                    return first >= second ? "true" : "false";

                case "<":
                    return first < second ? "true" : "false";

                case "<=":
                    return first <= second ? "true" : "false";

                case "==":
                    return first == second ? "true" : "false";

                case "!=":
                    return first != second ? "true" : "false";

                case "||":
                    return firstBool || secondBool ? "true" : "false";

                case "&&":
                    return firstBool && secondBool ? "true" : "false";

                default:
                    throw new Exception("Неизвестная операция");

            }

        }

        private void AnalyzerBrackets(ref string str, int startIndex, int endIndex)
        {
            string brackets = str.Substring(startIndex, endIndex - startIndex);

           

            int i = 0;
            while (i < brackets.Length)
            {
                string value1 = string.Empty;
                string value2 = string.Empty;

                while (!char.IsDigit(brackets[i]) && !char.IsLetter(brackets[i])) i++;

                value1 = ReturnVariable(ref i, brackets);

                string sign = ReturnSign(ref i, brackets);

                while (!char.IsDigit(brackets[i]) && !char.IsLetter(brackets[i])) i++;

                value2 = ReturnVariable(ref i, brackets);
                

                str = str.Replace(str.Substring(startIndex - 1, endIndex - startIndex + 2), BooleanResult(value1, value2, sign));

           
            }
        }

        private void IsTrueOrFalse(int index, ref string str)
        {
            int i = index;

            while (i < str.Length && str[i] != ')')
            {
                if (str[i] == '(')
                {
                    IsTrueOrFalse(i + 1, ref str);
                    i = i - 1;
                }

                i++;
            }

            if (i < str.Length && str[i] == ')')
            {
                AnalyzerBrackets(ref str, index, i);
            }
            while (i < str.Length && !str.StartsWith("{")) i++;
            while(i< str.Length && str[i]!='}')
            {

            }
        }


        public string Analyze(string[] lines)
        {
            int i = 0;
            string str = lines[i].TrimStart(' ', '\n', '\r');
            values.Clear();
            
            while (i < lines.Length && !str.StartsWith("while"))
            {
                if (str.StartsWith("int"))
                {
                    int j = 4;
                    while (j < str.Length && !char.IsLetter(str[j])) j++;

                    var variables = ReturnVariable(ref j, str);

                    while (j < str.Length && !char.IsDigit(str[j])) j++;

                    var digit = ReturnDigit(ref j, str);
                    
                    values.Add(variables, digit);

                }

                i++;
                if (i < lines.Length) str = lines[i].TrimStart(' ').ToLower();
            }

            string line = lines[i].ToLower();

            int index = lines[i].IndexOf('(');

            line = line.Remove(0, index);

            if (index >= 0) IsTrueOrFalse(1, ref line);
            

            return AnalyzerResult = line.Equals("true") ? "Выполнится: Хотя бы один раз выполнится" : "Выполнится: 0 раз";

        }
    }
}
