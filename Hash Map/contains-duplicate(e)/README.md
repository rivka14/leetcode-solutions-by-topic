# **Explanation: Contains Duplicate**

## **Problem:** [Contains Duplicate - LeetCode](https://leetcode.com/problems/contains-duplicate/)

### **Difficulty Level:** Easy

---

## **Description**
Given an integer array `nums`, return `true` if any value appears **at least twice** in
the array, and return `false` if every element is distinct.

---

## **Examples**

**Input:** `nums = [1,2,3,1]`
**Output:** `true`

**Input:** `nums = [1,2,3,4]`
**Output:** `false`

**Input:** `nums = [1,1,1,3,3,4,3,2,4,2]`
**Output:** `true`

---

## **Approach**

We use a **hash set** to remember the values we have already seen:

1. Iterate over `nums`.
2. If the current number is already in `seen`, a duplicate exists → return `True`.
3. Otherwise, add the number to `seen` and continue.
4. If the loop finishes without finding a repeat, every element was distinct → return `False`.

This lets us bail out as soon as a duplicate is found, instead of building the whole set
first and comparing its length to the array's length (the commented-out alternative in the
code, which works but always scans the entire array).

---

## **Time Complexity**
- **O(n)** — one pass over the array, with O(1) average-time hash-set lookups.

## **Space Complexity**
- **O(n)** — in the worst case (no duplicates) the set stores every element.

---

## **Code**

```python
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        seen = set()
        for n in nums:
            if n in seen:
                return True
            else:
                seen.add(n)
        return False


        # seen = set(nums)
        # return len(nums) > len(seen)
```
