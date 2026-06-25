# **Explanation: Move Zeroes**

## **Problem:** [Move Zeroes - LeetCode](https://leetcode.com/problems/move-zeroes/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Easy

---

## **Description**  
Given an integer array `nums`, move all `0`'s to the end of it while maintaining the relative order of the non-zero elements.  
You must do this **in-place** without making a copy of the array.

---

## **Example**  
**Input:** `nums = [0,1,0,3,12]`  
**Output:** `[1,3,12,0,0]`

**Input:** `nums = [0]`  
**Output:** `[0]`

---

## **Approach**

We use a **two-pointer** strategy to solve the problem in-place:

1. Initialize a `position` pointer at index `0`.  
2. Traverse the array:
   - If the current element is non-zero, write it to `nums[position]`, and increment `position`.
3. After placing all non-zero elements, fill the rest of the array with `0` from `position` to the end.

This way:
- All non-zero elements are moved forward in their original order.
- All zeroes are moved to the end.
- No extra space is used.

---

## **Time Complexity**
- **O(n)** – We iterate through the array twice (once to move elements, once to fill zeroes).

## **Space Complexity**
- **O(1)** – Only a single integer variable `position` is used.

---

## **Code**

```csharp
public class Solution {
    public void MoveZeroes(int[] nums) {
        int position = 0; 

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[position] = nums[i];
                position++; 
            }
        }

        for (int i = position; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}
```
