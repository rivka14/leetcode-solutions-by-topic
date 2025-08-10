# **Explanation: Reverse Vowels of a String**

## **Problem:** [Reverse Vowels of a String - LeetCode](https://leetcode.com/problems/reverse-vowels-of-a-string)

### **Difficulty Level:** Easy

---

## **Description**  
Given a string `s`, reverse only the vowels in the string and return the result.  
Vowels are `a, e, i, o, u` in both lower and upper case.

---

## **Examples**

**Input:** `s = "IceCreAm"`  
**Output:** `"AceCreIm"`  
**Explanation:** The vowels `['I','e','e','A']` are reversed to `['A','e','e','I']`.

**Input:** `s = "leetcode"`  
**Output:** `"leotcede"`

**Input:** `s = "aA"`  
**Output:** `"Aa"`

---

## **Approach**

We use a **two pointers** technique for a single linear pass:

1. Convert the string to a list so we can swap in place.
2. Keep a `left` pointer at the start and a `right` pointer at the end.
3. Advance `left` until it points to a vowel, and move `right` backward until it points to a vowel.
4. Swap the two vowels, then move both pointers inward.
5. Join the list back to a string.

This is clean, simple, and runs in linear time with constant-time membership checks using a `set`.

---

## **Time Complexity**
- **O(n)** where `n` is the length of `s`.

## **Space Complexity**
- **O(n)** in Python due to converting the string to a list for in-place swaps.

---

## **Code - Python**

```python
class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = set("aeiouAEIOU")
        chars = list(s)
        left, right = 0, len(chars) - 1

        while left < right:
            while left < right and chars[left] not in vowels:
                left += 1
            while left < right and chars[right] not in vowels:
                right -= 1
            chars[left], chars[right] = chars[right], chars[left]
            left += 1
            right -= 1

        return "".join(chars)
