using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeedCode
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] listcha = { 3, 2, 2, 3 };
            Console.WriteLine(LeedcodeSession.CountDigits(20));
        }






        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int value = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
