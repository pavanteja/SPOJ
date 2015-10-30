using System;
using System.Diagnostics;
using System.Collections.Generic;
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

            const int n = 99999989;
            int i = 0, j = 0;
            bool[] primes = new bool[n];
            primes[0] =  true;
            primes[1] = true;
            
            int root = (int)Math.Sqrt(n);
            for (i = 3; i < root; i=i+2)
            {
                if (!primes[i])
                {
                    for (j = i * i; j < n; j +=i)
                    {
                        primes[j] = true;
                    }
                }
            }
            watch.Stop();
            int c = 1; StringBuilder s = new StringBuilder();
            for (i = 3; i < n; i = i + 2)
            {
                if (!primes[i])
                {
                    if (c % 100 == 1)
                    {
                         //s.AppendLine(i+"");

                    }

                    c++;
                }

            }
            Console.WriteLine(s);
            //Console.WriteLine(sum);



            Console.WriteLine(c + " Primes");
            Console.WriteLine("--------------");

            var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine(elapsedMs);


            Console.ReadLine();
        }

    }
}
