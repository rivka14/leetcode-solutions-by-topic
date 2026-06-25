public class Solution {
    public string DecodeString(string s) {
        var repeatCounts   = new Stack<int>();
        var segmentStack   = new Stack<StringBuilder>();
        var currentSegment = new StringBuilder();
        int currentNumber  = 0;

        foreach (char ch in s)
        {
            if (char.IsDigit(ch))
            {
                currentNumber = currentNumber * 10 + (ch - '0');
            }
            else if (ch == '[')
            {
                repeatCounts.Push(currentNumber);
                segmentStack.Push(currentSegment);

                currentSegment = new StringBuilder();
                currentNumber = 0;
            }
            else if (ch == ']')
            {
                int repeat = repeatCounts.Pop();
                var parentSegment = segmentStack.Pop();

                for (int i = 0; i < repeat; i++)
                    parentSegment.Append(currentSegment);

                currentSegment = parentSegment;
            }
            else
            {
                currentSegment.Append(ch);
            }
        }

        return currentSegment.ToString();
    }
}
