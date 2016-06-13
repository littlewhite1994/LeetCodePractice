using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution345
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ReverseVowels("ai");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        /// <summary>
        /// 将一个字符串中所有的元音字母的位置互相调整。利用两个指针来，左指针和右指针来确定下标，进而完成元音字母的颠倒
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseVowels(string s)
        {
            #region
            //    string result = "";
            //    char[] chars = s.ToCharArray();
            //    int n = chars.Length / 2;
            //    if(chars.Length <= 2)
            //    {
            //        if(chars.Length == 2)
            //        {
            //            if (IsVowel(chars[0]) && IsVowel(chars[1]))
            //                return new String(new char[] {chars[1], chars[0]});
            //            else return s;
            //        }
            //        else
            //        {
            //            return s;
            //        }
            //    }
            //    int lindex = -1;
            //    int rindex = -1;
            //    for (int i = n; i >= 0; i--)
            //    {
            //        if (IsVowel(chars[i]))
            //        {
            //            lindex = i;
            //            break;
            //        }

            //    }
            //    for (int i = n+1; i < chars.Length; i++)
            //    {
            //        if (IsVowel(chars[i]))
            //        {
            //            rindex = i;
            //            break;
            //        }

            //    }
            //    if(lindex >=0 && rindex >= 0)
            //    {
            //        char temp = chars[lindex];
            //        chars[lindex] = chars[rindex];
            //        chars[rindex] = temp;
            //        Console.WriteLine("left is " + chars[lindex] + "\tright is " + chars[rindex]);
            //    }
            //    result = new String(chars);
            //    return result;
            //}

            //static bool IsVowel(char c)
            //{
            //    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //        return true;
            //    else if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            //        return true;
            //    else
            //        return false;
            //}
            #endregion
            string vowels = "AEIOUaeiou";
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;
            while(left < right)
            {
                if(vowels.IndexOf(chars[left]) != -1)
                {
                    while (vowels.IndexOf(chars[right]) == -1)
                        right--;
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;

                    left++;
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return new String(chars);
        }
    }
}
