# **Explanation: Maximum Average Subarray I**

## **Problem:** [Maximum Average Subarray I - LeetCode](https://leetcode.com/problems/maximum-average-subarray-i/description/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Easy

---

## **Description**  
You are given an integer array `nums` consisting of `n` elements, and an integer `k`.  
Your task is to find the **maximum average value** of any contiguous subarray of length `k`.

---

## **Example**  
**Input:** `nums = [1,12,-5,-6,50,3]`, `k = 4`  
**Output:** `12.75`  
**Explanation:** The subarray `[12,-5,-6,50]` has the maximum average `12.75`.

---

## **Approach**

We use the **Sliding Window** technique to solve this problem efficiently.  
Instead of computing the sum of every subarray of length `k` from scratch, we:
- Calculate the sum of the first `k` elements.
- Then, for each next element, we slide the window by **adding the new element** and **removing the element that just went out of the window**.
- We update the maximum sum accordingly and return the maximum average at the end.

---

### **Steps:**
1. **Initialize the first window sum:**
   - Use `nums[..k].Sum()` to calculate the sum of the first `k` elements.

2. **Track the maximum sum:**
   - Store the initial sum in a `max` variable.

3. **Slide the window across the array:**
   - For each index from `k` to `nums.Length - 1`:
     - Add `nums[right]` (the new element).
     - Subtract `nums[right - k]` (the element that leaves the window).
     - Update `max` if the new sum is larger.

4. **Return the maximum average:**
   - Divide `max` by `k` to get the maximum average.

---

### **Time Complexity:**
- **O(n)** where `n` is the length of the array. We go through the array once.

### **Space Complexity:**
- **O(1)** since we use only a few extra variables.

---

## **Code**

```csharp
public double FindMaxAverage(int[] nums, int k) 
{
    double sum = nums[..k].Sum();
    double max = sum;

    for (int right = k; right < nums.Length; right++) {
        sum += nums[right] - nums[right - k];
        max = Math.Max(max, sum);
    }

    return max / k;
}
