using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution344
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("hello"));
            Console.ReadKey();
        }
        /// <summary>
        /// 颠倒字符串，利用两个指针实现
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;
            while(left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
            return new String(chars);
        }

    }
}
