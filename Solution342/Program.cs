using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution342
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsPowerOfFour(16);
            Console.WriteLine(IsPowerOfFour(4));
            Console.ReadKey();
        }
        /// <summary>
        /// 判断一个数字是否是4的幂，
        /// 1，利用循环或者递归来实现。
        /// 2，利用数的二进制特点来实现，4的幂都可以用1向左移2n个位来表示。
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsPowerOfFour(int num)
        {
            #region
            //if (num == 1) return true;
            //int i = 1;
            //while(num % 4 == 0)
            //{
            //    num /= 4;
            //}
            //if (num == 1) return true;
            //return false;
            #endregion
            return ((num - 1) & num) == 0 && (num - 1) % 3 == 0;
        }
    }
}
