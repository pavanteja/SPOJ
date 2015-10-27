using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// FCTRL2 - Small factorials
/// </summary>
namespace SPOJ
{
    class SPOJ24
    {
        public static void Main()
        {
            int[] l = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int n in l)
            {
                string x = "1";
                for (int i = 1; i <= n; i++)
                {
                    x = mul(x, i);
                }
                Console.WriteLine(x);

            }
            Console.ReadLine();
        }

        private static string mul(string x, int n)
        {
            char[] ca = x.ToCharArray();
            int l = ca.Length;
            int carry = 0;
            string res = "";
            while (l > 0)
            {
                int xp = Convert.ToInt32(ca[l - 1]+"");
                l--;
                int pp = (xp * n) + carry;
                if (pp >= 10)
                {
                    carry = (int)(pp / 10);
                    res = (pp % 10) + res;
                }
                else
                {
                    carry = 0;
                    res = pp + res;
                }


            }
            if (carry > 0)
            {
                res = carry + res;
            }

            return res;
        }

    }
}
