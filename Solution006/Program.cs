using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 3));
            Console.ReadKey();
        }
        /// <summary>
        /// ZigZag转换
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            string res = "";
            int cellNum = numRows * 2 - 2;
            for (int i = 0; i < numRows; i++)
            {
                int j = i;
                int step = cellNum - 2 * i;
                while(j < s.Length)
                {
                    res += s[j];
                    if (step == 0 || step == cellNum)
                        j += cellNum;
                    else
                    {
                        j += step;
                        if (j >= s.Length)
                            break;
                        res += s[j];
                        j += (cellNum - step);
                    }
                }
            }
            return res;
        }
    }
}
