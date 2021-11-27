namespace LeetCode.Arrays
{
    public class ArraysService
    {
        public int RemoveDuplicates(int[] nums) {
            var j = 1;
            var numsLength = nums.Length;

            if (numsLength == 0)
            {
                return 0;
            }
        
            for(var i = 1; i < numsLength; i++){
                if(nums[i] != nums[i-1]){
                    if(j != i){
                        nums[j] = nums[i];
                    }
                
                    if(i != numsLength){
                        j++;
                    }
                }
            }   
        
            return j;
        }
    }
}