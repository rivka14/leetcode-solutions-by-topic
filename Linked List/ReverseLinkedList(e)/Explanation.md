# Reverse Linked List - Explanation  

## **Problem:** [Reverse Linked List - LeetCode](https://leetcode.com/problems/reverse-linked-list/description/?envType=study-plan-v2&envId=leetcode-75) 
 
### Difficulty Level: Easy 

## Description
You are given the head of a singly linked list. You need to reverse the list and return its head.

## Example:
Input: `1 -> 2 -> 3 -> 4 -> 5 -> NULL`   
Output: `5 -> 4 -> 3 -> 2 -> 1 -> NULL`

## Approach:

### Steps:
1. **Base Case:**  
   If the list is empty (`head == null`) or contains only one node (`head.next == null`), there is nothing to reverse. In this case, we simply return the head.

2. **Initialize Variables:**
   - `nextTemp`: This will temporarily store the next node in the list while we reverse the links.
   - `reverseHead`: This will store the new head of the reversed list, initially set to `null`.

3. **Iterate through the list:**
   We will traverse the list using a `while` loop, and for each node:
   - Store the next node in `nextTemp`.
   - Reverse the link of the current node by pointing its `next` to the `reverseHead`.
   - Move the `reverseHead` pointer to the current node, making it the new head of the reversed list.
   - Move to the next node using `nextTemp`.

4. **Return the reversed list:**
   After the loop, the `reverseHead` will be pointing to the new head of the reversed list.

### Time Complexity:
- **O(n)** where `n` is the number of nodes in the list. We are traversing the list once.

### Space Complexity:
- **O(1)** because we are using only a few pointers for the reversal process and no extra space for storing the list.

---

## Code:

```csharp
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
            return head;
        
        ListNode nextTemp = head.next, reverseHead = null;

        while(head != null)
        {
            nextTemp = head.next;
            head.next = reverseHead;
            reverseHead = head;
            head = nextTemp;
        }

        return reverseHead;
    }
}
