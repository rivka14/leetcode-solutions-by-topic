# **Explanation: Reverse String**

## **Problem:** [Reverse String - LeetCode](https://leetcode.com/problems/reverse-string/)

### **Difficulty Level:** Easy

---

## **Description**  
Write a function that reverses a string. The input string is given as an array of characters `s`.  
You must do this by modifying the input array **in-place** with `O(1)` extra memory.

---

## **Examples**  
**Input:** `s = ["h","e","l","l","o"]`  
**Output:** `["o","l","l","e","h"]`

**Input:** `s = ["H","a","n","n","a","h"]`  
**Output:** `["h","a","n","n","a","H"]`

---

## **Approach**

We use a **two-pointer** strategy to reverse the array in-place:

1. Initialize `left` at index `0` and `right` at the last index `len(s) - 1`.
2. While `left < right`:
   - Swap the characters at `s[left]` and `s[right]`.
   - Move `left` forward and `right` backward.
3. Stop when the pointers meet in the middle — every pair has been swapped.

This reverses the array without allocating a new one.

---

## **Time Complexity**
- **O(n)** – Each character is visited once as the two pointers move toward the center.

## **Space Complexity**
- **O(1)** – The swaps are done in-place using only two index variables.

---

## **Code**

```python
class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        left, right = 0, len(s) - 1
        while left < right:
            s[left], s[right] = s[right], s[left]
            left += 1
            right -= 1
```
