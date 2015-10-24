using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class SPOJ1
    {
        static void Main1(string[] args)
        {
            string input = "";
            while(true)
            {
                Int64 n = Convert.ToInt64(Console.ReadLine());
                if(n==42)
                {
                    string [] a = input.Trim().Split(' ');
                    foreach(string s in a)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                }
                input += n+" ";
            }
            Console.ReadKey();
        }
    }
}
