# **Explanation: Two Sum**

## **Problem:** [Two Sum - LeetCode](https://leetcode.com/problems/two-sum/)

### **Difficulty Level:** Easy

---

## **Description**  
Given an array of integers `nums` and an integer `target`, return the **indices** of the two numbers that add up to `target`.

- Each input has **exactly one** solution.
- You may **not** use the same element twice.
- You can return the answer in any order.

---

## **Examples**

**Input:** `nums = [2,7,11,15]`, `target = 9`  
**Output:** `[0,1]`  
**Explanation:** `nums[0] + nums[1] == 9`, so we return `[0, 1]`.

**Input:** `nums = [3,2,4]`, `target = 6`  
**Output:** `[1,2]`

**Input:** `nums = [3,3]`, `target = 6`  
**Output:** `[0,1]`

---

## **Approach**

We use a **hash map** to remember numbers we have already seen, mapping each value to its index:

1. Iterate over the array with both index `i` and value `num`.
2. Compute the `complement = target - num` — the value we still need to reach `target`.
3. If the complement is already in the map, we found the pair → return its stored index and the current index `i`.
4. Otherwise, store the current `num` and its index in the map and continue.

A single pass is enough because by the time we reach the second number of a valid pair, its partner is already in the map.

---

## **Time Complexity**
- **O(n)** — one pass over the array, with O(1) average-time hash-map lookups.

## **Space Complexity**
- **O(n)** — in the worst case the map stores every element.

---

## **Code**

```python
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        prev_nums = {}
        for i, num in enumerate(nums):
            complement_num = target - num
            if complement_num in prev_nums:
                return [prev_nums[complement_num], i]

            prev_nums[num] = i

        return []
```
