using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace SPOJ
{
    class PrimeSieveBitVector
    {
        public static void MainBv()
        {

             var watch = Stopwatch.StartNew();
            const int n = 86028113;//100000000;//99999989;
            int i = 3, j = 0;

            //masks[0] = BitVector32.CreateMask();
            //for (i = 1; i < n; i++)
            //{
            //    masks[i] = BitVector32.CreateMask(masks[i - 1]);
            //}



            bool[] bv = new bool[n];
            
            int root = 10000;
           
            for (; i < root; i = i + 2)
            {
                if (!bv[i])
                {
                    for (j = i * i; j < n; j += i)
                    {

                        bv[j] = true;
                    }
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine(elapsedMs);
            int c = 2; StringBuilder s = new StringBuilder();
            for (i = 1; i < n; i = i + 2)
            {
                if (!bv[i])
                {
                    //if (c % 100 == 1)
                    // {
                    //s.AppendLine(i + "");
                    if (c == 5000000)
                        Console.WriteLine(i);
                    // }

                    c++;
                }

            }
            // Console.WriteLine(2);
            // Console.Write(s);
            //Console.WriteLine(sum);



            Console.WriteLine(c - 1 + " Primes");
            Console.WriteLine("--------------");

          


            Console.ReadLine();
        }

    }
}
