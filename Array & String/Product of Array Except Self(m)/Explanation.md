# **Explanation: Product of Array Except Self**

## **Problem:**
[Product of Array Except Self - LeetCode](https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Medium

---

## **Description**
Given an integer array `nums`, return an array `answer` such that `answer[i]` is equal to the product of all the elements of `nums` except `nums[i]`.

The algorithm must run in **O(n)** time and without using division.

---

## **Example**

**Input:** nums = [1,2,3,4]  
**Output:** [24,12,8,6]  

**Explanation:**  
- answer[0] = 2 × 3 × 4 = 24  
- answer[1] = 1 × 3 × 4 = 12  
- answer[2] = 1 × 2 × 4 = 8  
- answer[3] = 1 × 2 × 3 = 6  

---

**Input:** nums = [-1,1,0,-3,3]  
**Output:** [0,0,9,0,0]  

---

## **Approach**
We avoid division by using prefix and suffix products:

1. Initialize `answer` array with all 1s.  
2. Traverse from left to right, storing the **prefix product** (product of all elements before the current index).  
3. Traverse from right to left, multiplying each `answer[i]` with the **suffix product** (product of all elements after the current index).  
4. This ensures each position `answer[i]` contains the product of all elements except `nums[i]`.

---

## **Time Complexity**
- **O(n)** one pass for prefix, one pass for suffix.  

## **Space Complexity**
- **O(1)** extra space (ignoring the output array).  

---

## **Code**
```python
def productExceptSelf(self, nums: List[int]) -> List[int]:
    n = len(nums)
    answer = [1] * n

    prefix = 1
    for i in range(n):
        answer[i] = prefix
        prefix *= nums[i]

    suffix = 1
    for i in reversed(range(n)):
        answer[i] *= suffix
        suffix *= nums[i]

    return answer
