using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Prime Generator
/// </summary>
namespace SPOJ
{
    class SPOJ2
    {
        static void Main2(string[] args)
        {
            int tl = Convert.ToInt32(Console.ReadLine());
            string[] ranges = new string[tl];
            for (int t = 1; t <= tl; t++)
            {

                ranges[t - 1] = Console.ReadLine();

            }
            foreach (string range in ranges)
            {
                string[] max_min = range.Trim().Split();
                Int64 m = Convert.ToInt64(max_min[0]);
                Int64 n = Convert.ToInt64(max_min[1]);
                if (n - m <= 100000)
                {
                    for (; m <= n; m = m + 1)
                    {


                        if (m == 1)
                        {
                            continue;
                        }

                        if (is_prime(m))
                        {
                            Console.WriteLine(m);
                        }

                        if (m % 2 != 0)
                        {
                            m++;
                        }

                       


                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static Boolean is_prime(long n)
        {
            if (n < -1)
                return false;
            else if (n <= 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;

            long i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
                i = i + 6;

            }
            return true;

        }
   
   
   
    }
}


/*

                    Boolean[] a = new Boolean[n+1];
                    for(Int64 i=2;i<=Math.Sqrt(n);i++)
                    {
                        if(a[i]==false)
                        {
                            Int64 c = 0;
                            for(Int64 j=i* i;j<=n;j=(i*i)+(c*i))
                            {
                                c++;
                                a[j] = true;
                            }
                        }
                    }

                    for(Int64 k=0;k<a.Length;k++)
                    {
                        if(a[k]==false && k>=m && k!=1)
                        Console.WriteLine(k);
                    }
*/

/*
for (Int64 i = m; i <= n; i++)
                    {
                        for(Int64 j=2;j<=i;j=j+2)
                        {
                            if (i % j == 0)
                            {
                                if (i == j)
                                {
                                    Console.WriteLine(i);

                                }
                                
                                break;
                                
                            }
                            if (j == 2)
                                j++;

                        }
                    }
*/
