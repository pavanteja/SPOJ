using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Factorial   
/// </summary>
namespace SPOJ
{
    class SPOJ11
    {
        public static void Main11()
        {

            string[] l = new string[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = Console.ReadLine();
            }
            
            foreach (string n in l)
            {
                int res = 0;
                ulong num = Convert.ToUInt64(n);
                double s = 5;
                int i = 0;
               
                while(s<=num)
                {
                   s= Math.Pow(5,++i);
                    res += (int)(num / s);
                }
                Console.WriteLine(res);
            }

            Console.ReadLine();
        }
    }
}
