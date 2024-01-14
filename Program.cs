using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArrayDuplicateRemoval_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {0, 0, 1, 1, 1, 1, 2, 3, 3};
            int k = RemoveDuplicates(nums);
            Array.Resize(ref nums, k);
            Console.WriteLine("[ " + String.Join(", ", nums) + $" ] --- {k}");
        }

        static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length <= 2) return nums.Length;

            int count = 2;

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[count - 2])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }

            return count;
        }
    }
}
