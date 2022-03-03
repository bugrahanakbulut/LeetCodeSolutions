public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        if (nums == null || nums.Length == 0) 
        {
            return 0;
        }

        int lastIndex = 1;
        int last = nums[0];

        for (int i = 1; i < nums.Length; i++) 
        {
            if (last != nums[i])
            {
                last = nums[i];
                nums[lastIndex] = last;
                lastIndex++;
            }
        }

        return lastIndex;
    }
}