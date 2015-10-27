using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// NSTEPS - Number Steps
/// </summary>
namespace SPOJ
{
    class SPOJ1112
    {
        public static void Main1112()
        {
            string[] l = new string[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = Console.ReadLine();
            }

            foreach (string n in l)
            {
                string[] nums = n.Split();
                int x = Convert.ToInt32(nums[0]);
                int y = Convert.ToInt32(nums[1]);
                if (x == y || x == y + 2)
                {
                    Console.WriteLine(x % 2 == 0 ? x + y : x + y - 1);
                }
                else
                {
                    Console.WriteLine("No Number");
                }





            }
            Console.ReadLine();
        }

    }
}
