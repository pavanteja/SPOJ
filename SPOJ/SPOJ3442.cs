using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class SPOJ3442
    {
        public static void Main3442()
        {


            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = (Console.ReadLine()).Split();
                var watch = Stopwatch.StartNew();
                int a = Convert.ToInt32(input[0]) % 10;
                int bi = Convert.ToInt32(input[1]);
                int b = bi % 4;
                if (b == 0 && bi > 0)
                {
                    b = 4;
                }

                Console.WriteLine(Math.Pow(a, b) % 10);
                Console.WriteLine("--------------");
                var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
                Console.WriteLine(elapsedMs);
            }




            Console.ReadLine();
        }
    }
}
