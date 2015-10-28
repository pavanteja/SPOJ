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
            bool[] numbers = new bool[n];
            numbers[0] = true;
            numbers[1] = true;
            for (int i = 2; i <Math.Sqrt(n); i++)
            {
                for (int j = i*i; j < n; j++)
                {
                    if (j%i==0)
                    {
                        numbers[j] = true;
                    }
                }

            }
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                if (!numbers[i])
                {
                    if(c%100==1)
                    {
                        Console.WriteLine(i);
                    }
                    c++;
                }

            }

            watch.Stop();
            Console.WriteLine("---------");
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadLine();
        }

    }
}
