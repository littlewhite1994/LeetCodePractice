using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution027
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElement(nums, 3));
            Console.ReadKey();
        }
        /// <summary>
        /// 给出一个数组和一个值，移除所有该值的实例，并返回移除后数组的长度。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right)
            {
                if(nums[left] == val)
                {
                    nums[left] = nums[right];
                    right--;
                    continue;
                }
                left++;
            }
            
            return left;
        }
    }
}
