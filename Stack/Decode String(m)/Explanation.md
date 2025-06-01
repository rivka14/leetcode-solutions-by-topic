# **Explanation: Decode String**

## **Problem:** [Decode String - LeetCode](https://leetcode.com/problems/decode-string/description/)

### **Difficulty Level:** Medium

---
 
## **Description**  
Given an encoded string, return its decoded string.  

The encoding rule is: **k[encoded_string]**, where the encoded_string inside the square brackets is repeated exactly `k` times.  
You can assume the input string is always valid - no extra white spaces, no invalid brackets, and the original data does not contain digits except for repeat numbers.

---

## **Example**  
**Input 1:** `s = "3[a]2[bc]"`  
**Output 1:** `"aaabcbc"`

**Input 2:** `s = "3[a2[c]]"`  
**Output 2:** `"accaccacc"`

**Input 3:** `s = "2[abc]3[cd]ef"`  
**Output 3:** `"abcabccdcdcdef"`

---

## **Approach**

We use **two stacks** to handle the nested decoding:  
- One stack (`repeatCounts`) stores the repeat counts for each level.
- Another stack (`segmentStack`) stores the partially built string segments before entering a nested level.

---

### **Steps:**
1. **Initialize variables:**
   - `currentNumber`: to build multi-digit numbers.
   - `currentSegment`: to build the current substring.

2. **Iterate over each character:**
   - If the character is a digit, build the `currentNumber`.
   - If `'['` is encountered:
     - Push `currentNumber` onto `repeatCounts`.
     - Push `currentSegment` onto `segmentStack`.
     - Reset `currentSegment` and `currentNumber`.
   - If `']'` is encountered:
     - Pop the repeat count and previous segment.
     - Append the repeated current segment to the previous one.
     - Update `currentSegment` with this combined result.
   - If it's a regular character, append it to `currentSegment`.

3. **Return the result:**
   - After processing all characters, return `currentSegment` as the final decoded string.

---

### **Time Complexity:**  
- **O(n)** where `n` is the length of the string - each character is processed once.

### **Space Complexity:**  
- **O(n)** due to the space used by the stacks and string builders.

---

## **Code**

```csharp
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
