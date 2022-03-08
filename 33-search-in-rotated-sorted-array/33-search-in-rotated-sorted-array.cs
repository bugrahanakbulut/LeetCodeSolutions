public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int pivot = FindPivotIndex(nums);
        
        int searchLeft = BinarySearch(nums, 0, pivot - 1, target);
        int searchRight = BinarySearch(nums, pivot, nums.Length - 1, target);

        return Math.Max(searchLeft, searchRight);
    }

    private int FindPivotIndex(int[] nums) 
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) 
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right]) 
            {
                left = mid + 1;
            }
            else 
            {
                right = mid;
            }
        }

        return right;
    }

    private int BinarySearch(int[] nums, int low, int max, int target) 
    {
        int left = low;
        int right = max;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        if (nums[left] == target) 
        {
            return left;
        }

        return -1;
    }
}