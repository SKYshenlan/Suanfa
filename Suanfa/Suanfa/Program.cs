using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suanfa
{
    internal class Program
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode ReverseList(ListNode head)
        {
            // 定义新链表
            ListNode arr = null;
            // 定义接收链表
            ListNode Newarr = head;
            // 循环
            while(Newarr != null)
            {
                // 保存下一个
                ListNode index = Newarr.next;
                //反转:指针指向前一个节点
                Newarr.next = arr;
                // 更新节点
                arr = Newarr;
                // 将保存的返还
                Newarr = index;
            }
            return arr;
        }
        //有效括号
        public static bool IsValid(string s)
        {
            // 先判断s
            if(string.IsNullOrEmpty(s)) return false;
            // 创建括号字典
            Dictionary<char,char> dic = new Dictionary<char, char>()
            {
                {')','(' },
                {']','[' },
                {'}','{' }
            };
            // 初始化栈
            Stack<char> chars = new Stack<char>();
            // 遍历s
            foreach(char c in s)
            {
                // 判断字典
                if (dic.ContainsKey(c))
                {
                    // 判断栈中数据
                    if (chars.Count == 0 || chars.Pop() != dic[c])
                    {
                        return false;
                    }
                }
                else
                {
                    // 存入栈
                    chars.Push(c);
                }
            }
            return chars.Count == 0;
        }
        //排序链表
        public ListNode SortList(ListNode head)
        {
            if(head == null || head.next == null) return head;

            //快慢针
            ListNode slow = head;
            ListNode flow = head.next;
            //拆分
            while(flow != null && flow.next != null)
            {
                slow = slow.next;
                flow = flow.next.next;
            }
            ListNode list = slow.next;
            slow.next = null;
            //排序

            ListNode left = SortList(head);
            ListNode right = SortList(list);
            //合并
            return Merag(left, right);
        }

        private ListNode Merag(ListNode arr1, ListNode arr2)
        {
            ListNode index = new ListNode(0);
            ListNode count = index;
            while(arr1 != null && arr2 != null)
            {
                if (arr1.val <= arr2.val)
                {
                    count.next = arr1;
                    arr1 = arr1.next;
                }
                else
                {
                    count.next = arr2;
                    arr2 = arr2.next;
                }
                count=count.next;
            }
            count.next = (arr1 != null) ? arr1 : arr2;
            return index.next;
        }
        //
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] arr = nums;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        int[] index = { i, j };
                        return index;
                    }
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] arr = {  3, 2, 4 };
            bool flag = IsValid("{()}");
            int[] newarr = TwoSum(arr, 6);
            Console.WriteLine();
        }
    }
}
