using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suanfa6_0
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    internal class Program
    {
        public bool IsPalindrome(ListNode head)
        {
            //快慢指针
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            // 反转
            ListNode arr = null;
            ListNode newArr = slow;
            while(newArr != null)
            {
                ListNode index = newArr.next;
                newArr.next = arr;
                arr = newArr;
                newArr = index;
            }
            // 对比
            ListNode first = head;
            ListNode second = arr;
            while(second != null)
            {
                if(first.val != arr.val)
                {
                    return false;
                }
                first = first.next;
                second = second.next;
            }
            return true;
        }
        static void Main(string[] args)
        {
        }
    }
}
