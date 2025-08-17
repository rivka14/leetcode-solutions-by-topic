# **Explanation: Reverse Words in a String**

## **Problem:** [Reverse Words in a String - LeetCode](https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Medium

---

## **Description**  
Given an input string `s`, reverse the order of the words.  

- A word is defined as a sequence of non-space characters.  
- Words in `s` will be separated by at least one space.  
- The returned string should only have a single space separating the words.  
- Do not include extra spaces at the start or end.  

---

## **Examples**

**Input:** `s = "the sky is blue"`  
**Output:** `"blue is sky the"`  

**Input:** `s = "  hello world  "`  
**Output:** `"world hello"`  
**Explanation:** The reversed string should not contain leading or trailing spaces.  

**Input:** `s = "a good   example"`  
**Output:** `"example good a"`  
**Explanation:** Multiple spaces are reduced to a single space.  

---

## **Approach**

We can solve this efficiently using built-in string methods in Python:

1. **Split** the string by whitespace with `s.split()`.  
   - This automatically removes leading/trailing spaces and collapses multiple spaces into one.  
2. **Reverse** the list of words using `reversed(words)` or slicing `[::-1]`.  
3. **Join** the words with `" ".join(...)` to get the final string with a single space between words.  

---

## **Time Complexity**
- **O(n)** - where `n` is the length of the string. We scan once for splitting, once for reversing, and once for joining.  

## **Space Complexity**
- **O(n)** - to store the list of words and the final string.  

---

## **Code - Python**

```python
class Solution:
    def reverseWords(self, s: str) -> str:
        words = s.split()
        return " ".join(reversed(words))
