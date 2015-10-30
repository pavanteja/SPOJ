using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// ACPC10A - What’s Next
/// </summary>
namespace SPOJ
{
    class SPOJ7974
    {
        public static void Main7974()
        {


            while (true)
            {
                string series = Console.ReadLine();
                string[] snumbers = series.Split();
                int[] numbers = { Convert.ToInt32(snumbers[0]), Convert.ToInt32(snumbers[1]), Convert.ToInt32(snumbers[2]) };
                if (numbers[0] + numbers[1] + numbers[2] == 0)
                {
                    break;
                }
                string n = (numbers[1] - numbers[0] == numbers[2] - numbers[1]) ? "AP " + (numbers[2] + (numbers[2] - numbers[1])) : "GP " + (numbers[2]*numbers[2]/numbers[1]);
                Console.WriteLine(n);
            }
        }
    }
}
