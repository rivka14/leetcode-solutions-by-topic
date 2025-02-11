# **Explanation: Maximum Twin Sum of a Linked List** 

## **Problem:** [Maximum Twin Sum of a Linked List](https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/description/?envType=study-plan-v2&envId=leetcode-75)

### Difficulty Level: Medium 

## **Description:**
Given a **1-indexed** linked list with an even number of nodes, the **twin sum** is defined as the sum of the first and last node, the second and second-last node, and so on.  
The goal is to **find the maximum twin sum** among these pairs.

### **Example 1 (Even Length List):**
Input: `1 -> 2 -> 3 -> 4`  
Output: `5`  
**Explanation:**  
- Twin pairs: `(1,4) -> sum = 5`, `(2,3) -> sum = 5`  
- Maximum twin sum = `5`.

### **Example 2 (Even Length List with Different Values):**
Input: `5 -> 4 -> 2 -> 1`  
Output: `6`  
**Explanation:**  
- Twin pairs: `(5,1) -> sum = 6`, `(4,2) -> sum = 6`  
- Maximum twin sum = `6`.

## **Solution Explanation:**
The solution follows **three key steps**:  

### 1. **Find the Middle of the List**
   - Use the **slow/fast pointer technique** to find the middle of the list.  
   - The **slow** pointer moves one step at a time, while the **fast** pointer moves two steps at a time.  
   - By the time the **fast** pointer reaches the end, the **slow** pointer will be at the **middle** of the list.

### 2. **Reverse the Second Half of the List**
   - The second half of the list is reversed so that we can easily pair up the twin nodes.
   - This is done using the **iterative reverse linked list technique**.

### 3. **Calculate the Maximum Twin Sum**
   - Traverse both halves of the list **simultaneously**.
   - For each twin pair, calculate the sum and track the **maximum sum**.

## **Time Complexity:**
- **O(N)**: We traverse the list **three times** (finding the middle, reversing, and calculating max sum).  
- Each traversal is **O(N)**, but since we only do a few passes, the final complexity remains **O(N)**.

## **Space Complexity:**
- **O(1)**: No extra space is used apart from a few pointers.

---

## **Code Implementation:**
```csharp
public class Solution {
    public int PairSum(ListNode head) {
        if (head == null) 
            return 0;

        ListNode middle = FindMiddle(head);
        ListNode secondHalf = ReverseList(middle);

        int maxSum = 0;
        ListNode firstHalf = head;
        while (secondHalf != null) {
            maxSum = Math.Max(maxSum, firstHalf.val + secondHalf.val);
            firstHalf = firstHalf.next;
            secondHalf = secondHalf.next;
        }

        return maxSum;
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;

        while(head != null)
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }

    public ListNode FindMiddle(ListNode head)
    {
        ListNode slow = head, fast = head;

        while(fast != null && fast.next != null)
        {
           slow = slow.next;
           fast = fast.next.next;
        }

        return slow;
    }    
}
