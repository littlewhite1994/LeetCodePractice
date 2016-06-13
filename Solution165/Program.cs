using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Compare("1.1", "13.1"));
            Console.ReadKey();

        }

        public static int CompareVersion(string version1, string version2)
        {
            string[] sv1 = version1.Split(new char[] { '.' });
            string[] sv2 = version2.Split(new char[] { '.' });
            int[] iv1 = new int[sv1.Length];
            int[] iv2 = new int[sv2.Length];
            for (int i = 0; i < sv1.Length; i++)
            {
                iv1[i] = Int32.Parse(sv1[i]);
            }
            for (int i = 0; i < sv2.Length; i++)
            {
                iv2[i] = Int32.Parse(sv2[i]);
            }
            int len = iv1.Length - iv2.Length <= 0 ? iv1.Length : iv2.Length;
            for (int i = 0; i < len; i++)
            {
                if (iv1[i] > iv2[i])
                    return 1;
                else if (iv1[i] < iv2[i])
                    return -1;
                else
                    continue;
            }
            return 1;

        }
    }
}
