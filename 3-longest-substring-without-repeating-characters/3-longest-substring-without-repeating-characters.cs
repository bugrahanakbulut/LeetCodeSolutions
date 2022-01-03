public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        HashSet<char> curSubStr = new HashSet<char>();

        int start = 0;
        int end = 0;

        int longest = 0;

        while (end < s.Length) 
        {
            if (!curSubStr.Contains(s[end])) 
            {
                curSubStr.Add(s[end]);
                end++;

                longest = Math.Max(curSubStr.Count, longest);
            }
            else 
            {
                curSubStr.Remove(s[start]);
                start++;
            }
        }

        return longest;
    }
}