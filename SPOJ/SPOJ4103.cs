using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOJ
{
    class SPOJ4103
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            while (line!=null)
            { 
            line = getPal(line);
            Console.WriteLine(line);
            line = Console.ReadLine();
            }
        }
        public static string getPal(string line)
        {
            if (is_pal(line))
                return line;
            return line[0] + getPal(line.Substring(1, line.Length - 1)) + line[0];
        }

        public static bool is_pal(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
