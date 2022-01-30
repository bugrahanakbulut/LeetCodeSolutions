public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);

        IList<IList<int>> output = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++) 
        {
            if (i > 0 && nums[i] == nums[i - 1]) 
            {
                continue;
            }
            
            int low = i+1;
            int high = nums.Length - 1;

            while (low < high) 
            {                
                int sum = nums[low] + nums[high];

                if (-nums[i] == sum) 
                {
                    output.Add(new List<int>() { nums[i], nums[low], nums[high] });
                    
                    while (low < high && nums[low] == nums[low + 1]) 
                    {
                        low++;
                    }

                    while (low < high && nums[high] == nums[high - 1]) 
                    {
                        high--;
                    }             
                }
                
                if (sum < -nums[i])
                {                    
                    low++;
                }
                else 
                {                    
                    high--;
                }
            }
        }

        return output;
    }
}