using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution326
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(4));
            Console.ReadKey();
        }

        public static bool IsPowerOfThree(int n)
        {
            if (n == 1) return true;
            while(n > 0 && n % 3 == 0)
            {
                n /= 3;
            }
            if (n == 1) return true;
            else return false;
        }
    }
}
