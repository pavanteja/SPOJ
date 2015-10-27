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
            string[] l = new string[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = Console.ReadLine();
            }

            foreach (string n in l)
            {
                string d = mul(n, (Convert.ToInt32(n) - 1) + "");

                //Console.WriteLine("------");
                Console.WriteLine(d);

            }
            Console.ReadLine();
        }

        private static string mul(string A, string B)
        {
            if (Convert.ToInt32(B) <= 1)
            {
                return A;
            }

            string[] PartialProducts = new string[A.Length];
            for (int i = A.Length - 1, c = 0; i >= 0; i--, c++)
            {
                int dA = Convert.ToInt32(A[i] + "");
                int carry = 0;
                string partialproduct = "";
                for (int j = B.Length - 1; j >= 0; j--)
                {
                    int dB = Convert.ToInt32(B[j] + "");
                    int pp = (dB * dA) + carry;

                    partialproduct = "" + (pp % 10) + partialproduct;
                    if (pp >= 10)
                    {
                        carry = pp / 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    if (j == 0 && carry > 0)
                    {
                        partialproduct = carry + "" + partialproduct;
                    }
                }
                PartialProducts[c] = partialproduct;

            }
            //for (int i = 0; i < PartialProducts.Length; i++)
            //{
            //    for (int j = i + 1; j < PartialProducts.Length; j++)
            //    {
            //       Console.Write(" ");
            //    }
            //    Console.WriteLine(PartialProducts[i]);



            //}

            int carry1 = 0;
            string mres = "";
            int f = 0;
            if (PartialProducts.Length == 1)
            {
                mres = PartialProducts[0];
            }
            else
            {

                int pi = PartialProducts[0].Length ;
                for (int i = pi - 1 + PartialProducts.Length - 1; i >= 0; i--)
                {
                    int DA = 0, DB = 0;

                    if (i >= 1 && PartialProducts[0].Length <= i)
                    {
                        DA = Convert.ToInt32(PartialProducts[0][i - 1] + "");
                    }

                    if (f > 0 && i >= 0 && PartialProducts.Length == 2)
                    {
                        DB = Convert.ToInt32(PartialProducts[1][i] + "");
                    }
                    f = 1;
                    int sum = (DA + DB + carry1);


                    mres = "" + (sum % 10) + mres;
                    if (sum >= 10)
                    {
                        carry1 = sum / 10;
                    }
                    else
                    {
                        carry1 = 0;
                    }
                    if (i == 0 && carry1 > 0)
                    {
                        mres = carry1 + "" + mres;
                    }
                }
            }
            //Console.WriteLine(mres);
            return mul(mres, (Convert.ToInt32(B) - 1) + "");
        }

    }
}
