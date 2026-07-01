using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suanfa_7_1
{
    internal class Program
    {
        private Random ran = new Random();
        public int[] SortArray(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void QuickSort(int[] nums, int v1, int v2)
        {
            if (v1 >= v2) return;
            int index = ran.Next(v1, v2 + 1);
            Swap(nums, v1,index);
            int arr = nums[v1];
            int i = v1, j = v2;
            while(i < j)
            {
                while (i < j && nums[j] >= arr) j--;
                while (i < j && nums[i] <= arr) i++;
                if (i < j)
                {
                    Swap(nums,i,j);
                }
            }
            Swap(nums, v1, i);
            QuickSort(nums, v1, i - 1);
            QuickSort(nums, i + 1, v2);
        }

        private void Swap(int[] nums, int v1, int index)
        {
            int t = nums[v1];
            nums[v1] = nums[index];
            nums[index] = t;
        }

        static void Main(string[] args)
        {
        }
    }
}
