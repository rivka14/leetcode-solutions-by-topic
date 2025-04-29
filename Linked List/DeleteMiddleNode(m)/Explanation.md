# **Explanation: Delete the Middle Node of a Linked List**

## **Problem:** [Delete the Middle Node of a Linked List](https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/description/?envType=study-plan-v2&envId=leetcode).

### Difficulty Level: Medium

## **Description:**
Given a linked list, delete the middle node and return the updated list.  
If there are two middle nodes, delete the second middle node.

### **Examples:**
Input: `1 -> 2 -> 3 -> 4`  
Output: `1 -> 2 -> 4`  

Input: `1 -> 2 -> 3 -> 4 -> 5`  
Output: `1 -> 2 -> 4 -> 5`  

## **Approach:**
I used the **slow/fast pointer technique** to find the middle node of the linked list:

### 1. **Edge Case Handling:**
   - If the list is empty or contains only one node, return `null`.
   - Initialize a `slow` pointer at the head and a `fast` pointer at the head of the list.

### 2. **Iterating with Two Pointers:**
   - The **slow** pointer moves one step at a time, while the **fast** pointer moves two steps at a time.
   - By the time the **fast** pointer reaches the end of the list, the **slow** pointer will be at the middle node.

### 3. **Deleting the Middle Node:**
   - Once the middle node is found, we update the `next` pointer of the previous node (`slow`) to skip the middle node.
   - The middle node is explicitly deleted by setting its `next` pointer to `null`.

## **Time Complexity:**
- **O(N)**: We only traverse the list once.

## **Space Complexity:**
- **O(1)**: No additional space is used apart from the two pointers.

---
