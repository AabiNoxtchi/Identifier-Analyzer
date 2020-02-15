using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifierAnalyzer
{
    class Program
    {
        //vbojikova2000@yahoo.com

        private static string Analyse(string str)
        {
            string NotValidIdentifierMsg = "Not a valid identifier ! . ";
            string valididentifier = " Valid Identifier ";

            //if null
            if (string.IsNullOrEmpty(str))
            {
                return " Empty !!!";
            }
            //if keyword
            else if (Keywords.Contains(str))
            {
                return  " Key Word !"+ NotValidIdentifierMsg;
            }
            //if begins with @ and rest is keyword
            else if (str[0] == '@' && Keywords.Contains(str.Substring(1)))
            {
                return valididentifier;

            }
			//if first letter is invalid
           else if (!(
                (str[0] >= 'a' && str[0] <= 'z') ||
                (str[0] >= 'A' && str[0] <= 'Z') ||
                 str[0] == '_'
                 ))
            {
                return NotValidIdentifierMsg;
            }
            // if rest of string is invalid 
            else if (str.Length > 1)
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (!((str[i] >= 'a' && str[i] <= 'z')
                        || (str[i] >= 'A' && str[i] <= 'Z')
                        || (str[i] >= '0' && str[i] <= '9')
                        || str[i] == '_'))
                        return NotValidIdentifierMsg;
                }
            }

            return valididentifier;
        }

        public static HashSet<string> Keywords { get; } = new HashSet<string> {
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
        "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
        "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
        "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
        "long", "namespace", "new", "null", "object", "operator", "out", "override", "params",
        "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
        "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw",
        "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using",
        "virtual", "void", "volatile", "while"

            };

        static void Main(string[] args)
        {
            Console.WriteLine("\nWrite aword to check whether it is avalid C# identifier or not ? or * to exit (as * is not avalid identifier)");

            while (true)
            {

               
                string str = Console.ReadLine();
                if (str == "*") break;
               
                string result = Analyse(str);
                Console.WriteLine(result);
               
                Console.WriteLine( "____________________________________________________________________________________");

                
            }

            Console.WriteLine("Bye ...");
            Console.ReadLine();
        }
    }
}
