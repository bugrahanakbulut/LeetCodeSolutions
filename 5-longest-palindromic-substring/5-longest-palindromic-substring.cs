public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        if (s == null || s.Length == 0) 
        {
            return string.Empty;
        }

        int longestPal = 0;
        int start = 0;
        int end = 0;
        
        for (int i = 0; i < s.Length; i++) 
        {
            int pal1 = Expands(s, i, i);
            int pal2 = Expands(s, i, i + 1);

            pal1 = Math.Max(pal1, pal2);

            if (pal1 > longestPal)
            {
                longestPal = pal1;

                start = i - (longestPal - 1) / 2;
                end = i + longestPal / 2;
            }
        }

        return s.Substring(start, end - start + 1);
    }

    private int Expands(string s, int left, int right) 
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}