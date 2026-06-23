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
        static void Main(string[] args)
        {
           bool flag = IsValid("{()}");
            Console.WriteLine(flag);
        }
    }
}
