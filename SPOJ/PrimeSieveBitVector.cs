using System;
using System.Diagnostics;
using System.Text;

namespace SPOJ
{
    class PrimeSieveBitVector
    {
        public static void Main6471()
        {

            var watch = Stopwatch.StartNew();

            const int n = 100000000;//99999989;
            int i = 0, j = 0;
            bool[] primes = new bool[n];
            primes[0] = true;
            primes[1] = true;

            int root = (int)Math.Sqrt(n);
            for (i = 3; i < root; i = i + 2)
            {
                if (!primes[i])
                {
                    for (j = i * i; j < n; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            int c = 2; StringBuilder s = new StringBuilder();
            for (i = 1; i < n; i = i + 2)
            {
                if (!primes[i])
                {
                    if (c % 100 == 1)
                    {
                        s.AppendLine(i + "");

                    }

                    c++;
                }

            }
            Console.WriteLine(2);
            Console.Write(s);
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
