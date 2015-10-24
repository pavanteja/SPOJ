using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Transform the Expression   
/// </summary>
namespace SPOJ
{
    class SPOJ4
    {
        static void Main4(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] expressions = new string[t];
            for (int i = 0; i < t; i++)
            {
                expressions[i] = Console.ReadLine();
            }

            foreach (string expression in expressions)
            {
                string output = "";
                char[] tokens = expression.ToCharArray();
                char[] symbols = new char[tokens.Length];
                for (int i = 0; i < symbols.Length; i++)
                {
                    symbols[i] = ' ';
                }


                foreach (char token in tokens)
                {



                    if (token >= 97 && token <= 122)
                    {
                        output += token;
                    }

                    if (token == '+' || token == '-' || token == '*' || token == '/' || token == '^' || token == '(')
                    {
                        for (int i = 0; i < symbols.Length; i++)
                        {
                            if (symbols[i] == ' ')
                            {
                                symbols[i] = token;
                                break;
                            }

                        }
                    }

                    if (token == ')')
                    {
                        for (int i = symbols.Length - 1; i >= 0; i--)
                        {
                            if (symbols[i] == '(')
                            {
                                symbols[i] = ' ';
                                break;
                            }
                            else
                            {
                                if (symbols[i] != ' ')
                                {
                                    output += symbols[i];
                                    symbols[i] = ' ';
                                }
                            }
                        }
                    }

                }

                Console.WriteLine(output);

            }
            Console.ReadKey();
        }






    }
}
