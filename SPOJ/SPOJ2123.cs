using System;
/// <summary>
/// CANDY - Candy I
/// </summary>
namespace SPOJ
{
    class SPOJ2123
    {
        public static void Main2123()
        {
            int blocks = Convert.ToInt32(Console.ReadLine());
            while (blocks != -1)
            {
                int[] chocolates = new int[blocks];
                int sum = 0;
                int Ablocks = blocks;
                int moves = 0;
                while (blocks > 0)
                {
                    sum += chocolates[blocks - 1] = Convert.ToInt32(Console.ReadLine()); ;
                    blocks--;
                }
                if (sum % Ablocks != 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    int avg = sum / Ablocks;
                    for (int i = 0; i < chocolates.Length; i++)
                    {
                        if (chocolates[i] < avg)
                        {
                            moves += avg - chocolates[i];
                        }
                    }
                    Console.WriteLine(moves);
                }

                blocks = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
