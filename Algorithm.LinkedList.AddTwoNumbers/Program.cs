using System;

namespace Algorithm.LinkedList.AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode l13 = new ListNode(2, null);
            ListNode l12 = new ListNode(1, l13);
            ListNode l1 = new ListNode(0, l12);

            ListNode l23 = new ListNode(6, null);
            ListNode l22 = new ListNode(5, l23);
            ListNode l2 = new ListNode(4, l22);
            AddTwoNumbers(l1, l2);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode resultListNode = new ListNode(0);
            ListNode pre = resultListNode;

            while (l1 != null || l2 != null || carry > 0)
            {
                int sum = carry + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                carry = sum < 10 ? 0 : 1;
                pre.next = new ListNode(sum % 10);
                pre = pre.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            return resultListNode.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
