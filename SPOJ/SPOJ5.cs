using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class SPOJ5
    {
        static void Main(string[] args)
        {
            int K = Convert.ToInt32(Console.ReadLine());
            string[] l = new string[K];
            for (int i = 0; i < K; i++)
            {
                l[i] = Console.ReadLine();
            }

            foreach (string n in l)
            {
                Console.WriteLine();
                Console.WriteLine(n);
                int strlen = n.Length;
                string A = "", B = "", C = "";
                if (n.Trim('9') == "")
                {

                    string temp = "";
                    for (int j = 0; j < strlen - 1; j++)
                    {
                        temp += "0";
                    }
                    Console.WriteLine("1" + temp + "1");
                    continue;
                }
                if (strlen % 2 == 0)
                {
                    A = n.Substring(0, strlen / 2);
                    B = n.Substring(strlen / 2, strlen / 2);

                   
                }
                else
                {
                    A = n.Substring(0, strlen / 2);
                    C = n.Substring(strlen / 2, 1);
                    B = n.Substring((strlen / 2) + 1, strlen / 2);
                    //int CmpResult = Compare(A, B);

                    string Ar = Rev(A);
                   // if (CmpResult > 0)
                   // {
                   //     Console.WriteLine(A + C + Ar);
                   // }
                   // else if (CmpResult <= 0)
                   // {
                        int RCmpResult = Compare(Ar, B);

                        if (RCmpResult > 0)
                        {
                            Console.WriteLine(A + C + Ar);
                        }
                        else if (RCmpResult <= 0)
                        {
                            if (C == "9")
                            {
                                A = inc(A);
                                Console.WriteLine(A + 0 + Rev(A));
                            }
                            else
                            {
                                Console.WriteLine(A + (Convert.ToInt32(C) + 1) + Ar);
                            }
                        }

                   // }
                   
                }
            }

            Console.ReadLine();
        }

        private static int Compare(string Ap, string Bp)
        {
            char[] A = Ap.ToCharArray();
            char[] B = Bp.ToCharArray();
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] > B[i])
                {
                    return 1;
                }
                else if (A[i] < B[i])
                {
                    return -1;
                }
            }
            return 0;
        }

        private  static string inc(string n)
        {
            char[] cn = n.ToCharArray();
            int i = cn.Length-1;
            int carry = 1;
            while (i>=0)
            {
                if (carry == 0)
                    break;
                int x = Convert.ToInt32(cn[i].ToString())+carry;
                cn[i] = (x % 10).ToString()[0];
                carry = carry / 10;
                i--;
            }
            return new String(cn);
        }
        private static string Rev(string a)
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
