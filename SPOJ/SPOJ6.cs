using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///     Simple Arithmetics
/// </summary>
namespace SPOJ
{
    class SPOJ6
    {
        public static void Main6(string[] args)
        {
            int K = Convert.ToInt32(Console.ReadLine());
            string[] l = new string[K];
            for (int i = 0; i < K; i++)
            {
                l[i] = Console.ReadLine();
            }
            foreach (string n in l)
            {
                if (n.Contains('+'))
                {
                    add(n.Split('+'));
                }
                else if (n.Contains('-'))
                {
                    sub(n.Split('-'));
                }
                else
                {
                    mul(n.Split('*'));
                }


            }
            Console.ReadLine();
        }

        private static void mul(string[] v)
        {
            int l1 = v[0].Length;
            int l2 = v[1].Length;
            int rl = (l1 > l2 ? l1 : l2) + 1;
            char[] result = new char[rl];

            Console.WriteLine(v[0]);
            Console.WriteLine("+"+v[1]);
            int i = rl - 1;
            int carry = 0;
            while (i >= 0)
            {
                int A = Convert.ToInt32(v[0].ToString());
                int B = Convert.ToInt32(v[1].ToString());
                int x = A + B + carry;
                //cn[i] = (x % 10).ToString()[0];
                //carry = x / 10;
                i--;
            }

        }

        private static void sub(string[] v)
        {
            throw new NotImplementedException();
        }

        private static void add(string[] v)
        {


        }
    }
}
