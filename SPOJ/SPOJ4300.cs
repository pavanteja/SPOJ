using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// AE00 - Rectangles
/// </summary>
namespace SPOJ
{
    class SPOJ4300
    {
        public static void Main4300()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= i; n++)
            {
                Console.WriteLine(n + " - " + (n + (int)Math.Sqrt(n) - 1 + (n - 2) / 2));
            }


            Console.ReadLine();

        }
    }
}
