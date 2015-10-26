using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Adding Reversed Numbers   
/// </summary>
namespace SPOJ
{
    class SPOJ42
    {
        public static void Main42()
        {
           
            string[] l = new string[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = Console.ReadLine();
            }
            foreach (string n in l)
            {
                string[] ds = n.Split();
                Console.WriteLine(Rev(Rev(ds[0]) + Rev(ds[1])+""));
            }

            Console.ReadLine();
        }

        private static int Rev(string a)
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return Convert.ToInt32(new string(charArray));
        }
    }
}
