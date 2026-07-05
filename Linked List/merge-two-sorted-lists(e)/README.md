# **Explanation: Merge Two Sorted Lists**

## **Problem:** [Merge Two Sorted Lists - LeetCode](https://leetcode.com/problems/merge-two-sorted-lists/)

### **Difficulty Level:** Easy

---

## **Description**

You are given the heads of two sorted linked lists `list1` and `list2`.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

## **Examples**

**Input:** `list1 = [1,2,4], list2 = [1,3,4]`
**Output:** `[1,1,2,3,4,4]`

**Input:** `list1 = [], list2 = []`
**Output:** `[]`

**Input:** `list1 = [], list2 = [0]`
**Output:** `[0]`

## **Approach**

Use a dummy head node so that the result list has a consistent starting point regardless of which list contributes the first node. Maintain a `current` pointer that always points to the last node appended.

At each step, compare the values at the fronts of `list1` and `list2`, attach the smaller node to `current.next`, and advance that list's pointer. After one list is exhausted, attach the remainder of the other directly — no further traversal needed since it is already sorted.

Return `dummy.next` to skip the sentinel node.

## **Time Complexity**

- **O(m + n)** — each node from both lists is visited exactly once, where m and n are the lengths of `list1` and `list2`.

## **Space Complexity**

- **O(1)** — nodes are relinked in place; only the dummy node and a few pointers are allocated.

## **Code**

```python
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummy = ListNode(0)
        current = dummy

        while list1 and list2:
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next
            else:
                current.next = list2
                list2 = list2.next

            current = current.next

        current.next = list1 or list2
        return dummy.next
```
