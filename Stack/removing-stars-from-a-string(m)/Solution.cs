public class Solution
{
    public string RemoveStars(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c != '*')
                stack.Push(c);
            else if (stack.Count > 0)
                stack.Pop();
        }

        return new string(stack.Reverse().ToArray());
    }
}
