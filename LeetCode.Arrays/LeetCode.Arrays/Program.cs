using System;

namespace LeetCode.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,1,2,2,3,4,5,6,7,8,8,8,9,9}; // Input array
            int[] expectedNums = {1,2,3,4,5,6,7,8,9}; // The expected answer with correct length

            var arraysService = new ArraysService();
            
            int k = arraysService.RemoveDuplicates(nums); // Calls your implementation

            if (k == expectedNums.Length){
                for (int i = 0; i < k; i++)
                {
                    if (nums[i] == expectedNums[i])
                    {
                        
                    }
                }
            }
        }
    }
}