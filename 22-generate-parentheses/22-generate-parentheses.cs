public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        IList<string> result = new List<string>();

        GenerateParenthesis(result, "", 0, 0, n);

        return result;
    }

     private void GenerateParenthesis(IList<string> res, string curStr, int open, int close, int n) 
     {
        if (n * 2 == curStr.Length) 
        {
            res.Add(curStr);

            return;
        }

        if (open < n) 
        {
            GenerateParenthesis(res, curStr + "(", open + 1, close, n);
        }

        if (close < open) 
        {
            GenerateParenthesis(res, curStr + ")", open, close + 1, n);
        }
     }
}