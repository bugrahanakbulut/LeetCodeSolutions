public class Solution 
{
    private Dictionary<char, char> _parantehesisComp = new Dictionary<char, char>() 
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' },
    };

    public bool IsValid(string s) 
    {
        Stack<char> parantehesisStack = new Stack<char>();
        
        for (int i = 0; i < s.Length; i++) 
        {
            
            if (parantehesisStack.Count > 0 && 
                _parantehesisComp.ContainsKey(s[i]) &&
                _parantehesisComp[s[i]] == parantehesisStack.Peek()) 
            {
                parantehesisStack.Pop();
            }
            else 
            {
                parantehesisStack.Push(s[i]);
            }
        }

        return parantehesisStack.Count == 0;
    }
}