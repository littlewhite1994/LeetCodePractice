using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution002
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }

        public void printList()
        {
            ListNode current = this;
            while(current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
        }

        public static void printList2(ListNode root)
        {
            if(root != null)
            {
                Console.Write(root.val + " ");
                printList2(root.next);
            }
        }

        public void GetDeep()
        {
            int deep = 0;
            ListNode current = this;
            while(current != null)
            {
                deep++;
                current = current.next;
            }
            Console.WriteLine("the deep is " + deep);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode root = new ListNode(1);
            root.next = new ListNode(2);
            root.next.next = new ListNode(3);
            //root.printList();
            //ListNode.printList2(root);
            root.GetDeep();
            Console.ReadKey();
        }
        /// <summary>
        /// 将2个倒序表示的数字形成的数组相加。
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if(l1 != null || l2 != null)
            {

            }
            return l1;
        }
    }
}
