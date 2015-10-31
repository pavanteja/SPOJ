using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// FASHION - Fashion Shows
/// </summary>
namespace SPOJ
{
    class SPOJ1025
    {
        public static void Main1025()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                int[] MEN = new int[size];
                int[] WOMEN = new int[size];
                string[] inpMEN = Console.ReadLine().Split();
                for (int i = 0; i < size; i++)
                {
                    MEN[i] = Convert.ToInt32(inpMEN[i]);
                }
                string[] inpWOMEN = Console.ReadLine().Split();
                for (int i = 0; i < size; i++)
                {
                    WOMEN[i] = Convert.ToInt32(inpWOMEN[i]);
                }
                sort(ref MEN);
                sort(ref WOMEN);
                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    sum += Convert.ToInt32(MEN[i]) * Convert.ToInt32(WOMEN[i]);

                }
                Console.WriteLine(sum);
                t--;
            }
        }


        public static void sort(ref int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }
        }

    }

}
