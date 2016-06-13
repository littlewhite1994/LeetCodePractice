using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Solution347
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 1, 1, 2, 2, 3};
            int k = 3;
            //TopKFrequent(nums, k);
            int[] result = SortDown(nums);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + "\t");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 求出一个数组中K个最频繁出现的数字
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[k];
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], 0);
                dic[nums[i]]++;
            }
            for (int i = 0; i < k; i++)
            {
                dic.Values.Max();
            }
            return new int[]{ 1};
        }

        public static int[] SortDown(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] < nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
