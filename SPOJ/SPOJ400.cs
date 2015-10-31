using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// To and Fro
/// </summary>
namespace SPOJ
{
    class SPOJ400
    {
        public static void Main()
        {
            int columns = Convert.ToInt32(Console.ReadLine());

            while (columns != 0)
            {
                string line = Console.ReadLine();
                StringBuilder rline = new StringBuilder();
                for (int i = 0; i < columns; i++)
                {
                    for (int j = 0; j < line.Length / columns; j++)
                    {
                        if (j % 2 == 0)
                        {
                            rline.Append(line[(j * columns) + i]);
                        }
                        else
                        {
                            rline.Append(line[((j + 1) * columns) - i-1]);
                        }

                    }
                }
                Console.WriteLine(rline);
                columns = Convert.ToInt32(Console.ReadLine());
            }
        }

    }
}
