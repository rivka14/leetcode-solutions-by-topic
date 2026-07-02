# **Explanation: Palindrome Number**

## **Problem:** [Palindrome Number - LeetCode](https://leetcode.com/problems/palindrome-number/)

### **Difficulty Level:** Easy

---

## **Description**

Given an integer `x`, return `true` if `x` is a palindrome, and `false` otherwise.

An integer is a palindrome when it reads the same forward and backward.

## **Examples**

**Input:** `x = 121`
**Output:** `true`
**Explanation:** 121 reads as 121 from left to right and from right to left.

**Input:** `x = -121`
**Output:** `false`
**Explanation:** From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

**Input:** `x = 10`
**Output:** `false`
**Explanation:** Reads 01 from right to left. Therefore it is not a palindrome.

## **Approach**

Negative numbers can never be palindromes, so return `False` immediately for any `x < 0`.

For non-negative numbers, reverse the digits by repeatedly extracting the last digit (`x % 10`) and building the reversed number, then dividing `x` by 10. After the loop, compare the reversed number to the original.

## **Time Complexity**

- **O(log n)** — the number of digits in `x` is proportional to log₁₀(x), and we process each digit once.

## **Space Complexity**

- **O(1)** — only a fixed number of variables are used regardless of the input size.

## **Code**

```python
def isPalindrome(x):
    if x < 0:
        return False
    original = x
    reversed_num = 0
    while x > 0:
        digit = x % 10
        reversed_num = reversed_num * 10 + digit
        x //= 10
    return original == reversed_num
```
