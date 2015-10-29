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

            int n = 100000000;
            
            int[] primes = new int[n];
            
            
            primes[0] = 0 | 1;
            primes[1] = 0 | 1;
            
            int root = (int)Math.Sqrt(n);
            for (int i = 2; i < root; i++)
            {
                if ((primes[i] ) == 0)
                {
                    for (int j = i * i, k = 2; j < n;  j = i * ++k)
                    {
                        primes[j] =1;
                    }
                }
            }

            int c = 1; long sum1 = 0;
            for (int i = 1; i < n; i = i + 2)
            {
                if ((primes[i]) == 0)
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

    }
}
