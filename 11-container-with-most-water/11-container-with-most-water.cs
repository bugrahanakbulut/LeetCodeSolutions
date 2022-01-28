public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int left = 0;

        int right = height.Length - 1;

        int max = 0;

        while (left < right) 
        {
            int w = right - left;
            int h = Math.Min(height[left], height[right]);

            max = Math.Max(max, w * h);

            if (height[left] > height[right]) 
            {
                right--;
            }
            else 
            {
                left++;
            }
        }

        return max;
    }
}