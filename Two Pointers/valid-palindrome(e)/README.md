# **Explanation: Valid Palindrome**

## **Problem:** [Valid Palindrome - LeetCode](https://leetcode.com/problems/valid-palindrome/)

### **Difficulty Level:** Easy

---

## **Description**
A phrase is a **palindrome** if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string `s`, return `true` if it is a palindrome, or `false` otherwise.

---

## **Examples**

**Input:** `s = "A man, a plan, a canal: Panama"`
**Output:** `true`
**Explanation:** `"amanaplanacanalpanama"` is a palindrome.

**Input:** `s = "race a car"`
**Output:** `false`
**Explanation:** `"raceacar"` is not a palindrome.

**Input:** `s = " "`
**Output:** `true`
**Explanation:** After removing non-alphanumeric characters, `s` is an empty string, which reads the same forward and backward.

---

## **Approach**

We use a **two pointers** technique:

1. Set `left` at the start of the string and `right` at the end.
2. Move `left` and `right` toward each other, skipping any character that is not alphanumeric.
3. Compare the lowercase versions of `s[left]` and `s[right]`. If they differ, the string is not a palindrome.
4. If all comparisons pass until the pointers meet, the string is a palindrome.

---

## **Time Complexity**
- **O(n)** where `n` is the length of `s`, since each pointer traverses the string at most once.

## **Space Complexity**
- **O(1)** - constant extra space.

---

## **Code**

```python
class Solution:
    def isPalindrome(self, s: str) -> bool:
        left, right = 0, len(s) - 1

        while left < right:
            while left < right and not s[left].isalnum():
                left += 1

            while left < right and not s[right].isalnum():
                right -= 1

            if s[left].lower() != s[right].lower():
                return False

            left += 1
            right -= 1

        return True
```
