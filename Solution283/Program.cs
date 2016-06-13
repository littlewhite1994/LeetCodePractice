using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution283
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {0, 1, 0, 3, 12};
            MoveZeros(nums);
            Console.ReadKey();
        }
        /// <summary>
        /// 将0移动到数组的末尾，并保证非零元素的相对位置不变
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeros(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            
            for (int i = k; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
