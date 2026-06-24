using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suanfa6_24
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
        //重排链表
        public void ReorderList(ListNode head)
        {
            // 快慢指针
            ListNode slow = head;
            ListNode fast = head.next;
            // 拆分
            while(fast != null&& fast.next != null)
            {
                slow = slow.next;
                fast= fast.next.next;
            }
            // 反转
            ListNode arr = null;
            ListNode newArr = slow.next;
            slow.next = null;
            while(newArr != null)
            {
                // 保存下一个
                ListNode index = newArr.next;
                // 替换
                newArr.next = arr;
                // 赋值
                arr = newArr;
                // 保存的返还
                newArr = index;
            }
            // 合并
            ListNode first = head;
            ListNode second = arr;
            while(second != null)
            {
                ListNode tmp1 = first.next;
                ListNode tmp2 = second.next;
                first.next = second;
                second.next = tmp1;
                first = tmp1;
                second = tmp2;
            }
        }
        static void Main(string[] args)
        {
            // 手动构建链表: 1 -> 2 -> 3 -> 4 -> 5
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            // 调用重排
            Program sol = new Program();
            sol.ReorderList(head);
        }
    }
}
