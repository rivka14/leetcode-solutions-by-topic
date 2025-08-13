# **Explanation: Is Subsequence**

## **Problem:** [Is Subsequence - LeetCode](https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Easy

---

## **Description**  
Given two strings `s` and `t`, return `true` if `s` is a subsequence of `t`, or `false` otherwise.

A subsequence of a string is formed by deleting some (or none) of the characters from the original string without disturbing the relative positions of the remaining characters.

---

## **Examples**

**Input:** `s = "abc"`, `t = "ahbgdc"`  
**Output:** `true`  
**Explanation:** The characters `'a'`, `'b'`, `'c'` appear in `t` in the same order.

**Input:** `s = "axc"`, `t = "ahbgdc"`  
**Output:** `false`  
**Explanation:** The character `'x'` is missing in `t` in the correct sequence.

---

## **Approach**

We use a **two pointers** technique:

1. Set pointer `i` for string `s` and pointer `j` for string `t`.
2. Move through both strings:
   - If `s[i]` equals `t[j]`, move `i` forward (we found the next required character).
   - Always move `j` forward to keep searching in `t`.
3. If `i` reaches the length of `s`, it means all characters of `s` were found in order inside `t`.

---

## **Time Complexity**
- **O(n + m)** where `n` is the length of `s` and `m` is the length of `t`.

## **Space Complexity**
- **O(1)** - constant extra space.

---

## **Code - C#**

```csharp
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0; 
        int j = 0; 

        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) {
                i++;
            }
            j++; 
        }

        return i == s.Length; 
    }
}

