using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Play with dates-CODEIT03
/// Determination_of_the_day_of_the_week Kraitchik's variation
/// </summary>
namespace SPOJ
{
    class SPOJ10366
    {
        public static void Main10366()
        {
            int K = Convert.ToInt32(Console.ReadLine());
            string[] l = new string[K];
            if (K >= 1 && K <= 100)
            {
                for (int i = 0; i < K; i++)
                {
                    l[i] = Console.ReadLine();
                }

                int[] mo = { 0, 1, 4, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
                int[] ce = { 0, 5, 3, 1 };
                string[] days = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                foreach (string n in l)
                {
                    string[] p = n.Split(' ');
                    if (Convert.ToInt32(p[2]) >= 2012)
                    {

                        int d = Convert.ToInt32(p[0]);
                        int m = mo[Convert.ToInt32(p[1])];
                        int c = ce[Convert.ToInt32(p[2].Substring(0, 2)) % 4];
                        int s = Convert.ToInt32(p[2].Substring(2, 2));
                        if (p[1] == "1" || p[1] == "2")
                        {
                            s--;
                        }
                        int y = ((s / 4) + s) % 7;
                        int day = (d + m + c + y) % 7;
                        Console.WriteLine(days[day]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
