using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunafa_6_25
{
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

    internal class Program
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            ListNode node = new ListNode(0,head);
            ListNode arr = node;
            ListNode newArr = head;
            while (newArr != null)
            {
                if(newArr.val == val)
                {
                    arr.next = newArr.next;
                }
                else
                {
                    arr = newArr;
                }
                newArr = newArr.next;
            }
            return node;
        }
        static void Main(string[] args)
        {

        }
    }
}
