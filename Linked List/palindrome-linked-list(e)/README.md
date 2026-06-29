# **Explanation: Palindrome Linked List**

## **Problem:** [Palindrome Linked List - LeetCode](https://leetcode.com/problems/palindrome-linked-list/)

### **Difficulty Level:** Easy

---

## **Description**  
Given the `head` of a singly linked list, return `true` if it is a **palindrome** or `false` otherwise.  
A list is a palindrome when it reads the same forward and backward.

---

## **Examples**  
**Input:** `head = [1,2,2,1]`  
**Output:** `true`

**Input:** `head = [1,2]`  
**Output:** `false`

---

## **Approach**

We solve this in `O(n)` time and `O(1)` extra space using **slow/fast pointers** plus an **in-place reversal**:

1. **Find the middle** with two pointers: `slow` moves one step while `fast` moves two.
   When `fast` reaches the end, `slow` is at the start of the second half.
2. **Reverse the second half** of the list in place, building it up in `prev`.
3. **Compare the two halves**: walk `left` from `head` and `right` from `prev` (the head of
   the reversed second half). If any pair of values differs, it is not a palindrome.
4. If the right pointer reaches the end without a mismatch, the list is a palindrome.

Comparing only until `right` becomes `None` handles both even and odd lengths — for odd
lengths the middle node is shared and does not need to be checked.

---

## **Time Complexity**
- **O(n)** – One pass to find the middle, one to reverse the second half, and one to compare.

## **Space Complexity**
- **O(1)** – The reversal is done in place using only a few pointers.

---

## **Code**

```python
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        slow, fast = head, head
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next

        prev = None
        current = slow
        while current:
            current_next = current.next
            current.next = prev
            prev = current
            current = current_next

        left, right = head, prev
        while right:
            if left.val != right.val:
                return False
            left = left.next
            right = right.next

        return True
```
