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
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int sn = (int)Math.Sqrt(n);
            for (int i = 1; i <= sn; i++)
            {
                for (int j = i + 1; i * j <= n; j++)
                {
                    c++;
                }
            }

            Console.WriteLine(c + sn);

        }
    }
}
