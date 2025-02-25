# **Explanation: Removing Stars from a String**

## **Problem:** [Removing Stars from a String](https://leetcode.com/problems/removing-stars-from-a-string/)

### Difficulty Level: Medium 

## **Description:** 
Given a string `s` containing lowercase English letters and the `*` character, you need to remove characters based on the following rule:
- Each `*` removes the closest non-star character to its left.
- The process continues until no stars remain in the string.
- The final result should be returned as a string.

### **Example 1:** 
**Input:** `s = "leet**cod*e"`  
**Output:** `"lecoe"`  
**Explanation:**   
- The first `*` removes the closest `t`, resulting in `lee*cod*e`.
- The second `*` removes the closest `e`, resulting in `lecod*e`.
- The third `*` removes `d`, resulting in `lecoe`.

### **Example 2:**
**Input:** `s = "abc*de**f"`  
**Output:** `"af"`  
**Explanation:**  
- The first `*` removes `c`, resulting in `abde**f`.
- The second `*` removes `e`, resulting in `abd*f`.
- The third `*` removes `d`, resulting in `af`.

## **Solution Explanation:**
This solution efficiently processes the string using a **stack data structure** to handle character removals dynamically.

### **1. Using a Stack to Track Characters:**
- We iterate through the string and maintain a **stack** to store characters that are not `*`.
- When encountering a `*`, we remove the most recently added character (last-in, first-out behavior).

### **2. Constructing the Final String:**
- Once all operations are performed, the stack contains only the valid characters.
- The result is obtained by converting the stack into a string.

## **Time Complexity:**
- **O(N)**: We traverse the string once and perform `push` and `pop` operations on the stack, both of which take O(1) time.

## **Space Complexity:**
- **O(N)**: In the worst case, all characters (without `*`) are stored in the stack.

---

## **Code Implementation:**
```csharp
public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c != '*') 
                stack.Push(c);
            else if (stack.Count > 0) 
                stack.Pop();
        }

        return new string(stack.Reverse().ToArray());
    }
}
