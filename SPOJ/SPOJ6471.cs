using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Printing some primes
/// </summary>
namespace SPOJ
{
    class SPOJ6471
    {
        public static void Main()
        {

            var watch = Stopwatch.StartNew();

            int n = 10000000;
            
            //int[] primes = new int[n];
            
            
            //primes[0] = 0 | 1;
            //primes[1] = 0 | 1;
            
            //int root = (int)Math.Sqrt(n);
            //for (int i = 2; i < root; i++)
            //{
            //    if ((primes[i] ) == 0)
            //    {
            //        for (int j = i * i, k = 2; j <= n-1;  j = i * ++k)
            //        {
            //            primes[j] =1;
            //        }
            //    }
            //}

            int c = 1; int sum1 = 0;
            for (int i = 1; i < n; i = i + 2)
            {
                if (is_prime(i))
                {
                    if (c % 100 == 1)
                    {
                        sum1 += i;//.Append(i+"\n");

                    }

                    c++;
                }

            }
            //Console.WriteLine(sum);
            watch.Stop();
           

            Console.WriteLine(c - 1 + " Primes");
            Console.WriteLine("--------------");

            var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine(elapsedMs);


            Console.ReadLine();
        }
        public static bool is_prime(int n)
        {
            if (n <= 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;
            int i = 5;
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
