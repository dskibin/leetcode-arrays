using System;

namespace LeetCode.Arrays
{
    public class ArraysService
    {
        public int RemoveDuplicates(int[] nums)
        {
            var j = 1;
            var numsLength = nums.Length;

            if (numsLength == 0)
            {
                return 0;
            }

            for (var i = 1; i < numsLength; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    if (j != i)
                    {
                        nums[j] = nums[i];
                    }

                    if (i != numsLength)
                    {
                        j++;
                    }
                }
            }

            return j;
        }

        public int GetBestTimeToBuyAndSell(int[] nums)
        {
            var profit = 0;
            var lastPrice = 0;
            var holding = false;
            var numsLength = nums.Length;

            if (numsLength == 0)
            {
                return 0;
            }
            
            for (var i = 1; i < numsLength; i++)
            {
                if (nums[i] >= nums[i - 1])
                {
                    if (!holding)
                    {
                        lastPrice = nums[i - 1];
                        holding = true;
                    }
                }
                else
                {
                    if (holding)
                    {
                        profit += nums[i - 1] - lastPrice;
                        holding = false;
                    }
                }
                
            }

            if (holding)
            {
                profit += nums[numsLength - 1] - lastPrice;
            }

            return profit;
        }
    }
}