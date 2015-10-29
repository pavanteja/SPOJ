using System;
using System.Diagnostics;
using System.Text;

namespace SPOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            long n = 100000000;
            bool[] primes = new bool[n];
            primes[0] = true;
            primes[1] = true;

            long root = (long)Math.Sqrt(n);
            for (long i = 2; i < root; i++)
            {
                if (!primes[i])
                {
                    for (long j = i * 2, k = 2; j < n; k++, j = i * k)
                    {
                        primes[j] = true;
                    }
                }
            }
            long c = 1; StringBuilder sum=new StringBuilder() ;
            for (long i = 0; i < n; i++)
            {
                if (!primes[i])
                {
                    if (c % 100 == 1)
                    {
                        sum.AppendLine(i+"");
                      
                    }

                    c++;
                }

            }
            Console.WriteLine(sum);
            Console.WriteLine(c-1 + " Primes");
            Console.WriteLine("--------------");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds/1000.0;
            Console.WriteLine(elapsedMs);
            Console.ReadLine();
        }
    }
}
