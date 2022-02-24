public class Solution 
{
    private Dictionary<char, List<string>> _keys = new Dictionary<char, List<string>>() 
    {
        { '2', new List<string>() {"a", "b", "c"} },
        { '3', new List<string>() {"d", "e", "f"} },
        { '4', new List<string>() {"g", "h", "i"} },
        { '5', new List<string>() {"j", "k", "l"} },
        { '6', new List<string>() {"m", "n", "o"} },
        { '7', new List<string>() {"p", "q", "r", "s"} },
        { '8', new List<string>() {"t", "u", "v"} },
        { '9', new List<string>() {"w", "x", "y", "z"} },
    };

    public IList<string> LetterCombinations(string digits) 
    {
        if (digits.Length == 0) 
        {
            return new List<string>();
        }
        
        if (digits.Length == 1) 
        {
            return _keys[digits[0]];
        }

        IList<string> list = LetterCombinations(digits.Substring(1));
        List<string> chars = _keys[digits[0]];

        IList<string> res = new List<string>();

        foreach(string s in list) 
        {
            foreach(string c in chars) 
            {
                res.Add(c + s);
            }
        }

        return res;
    }
}