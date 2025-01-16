# Odd Even Linked List - Explanation

## Problem Description
Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

## Link to Problem
[Odd Even Linked List - LeetCode](https://leetcode.com/problems/odd-even-linked-list/?envType=study-plan-v2&envId=leetcode-75)

## Difficulty Level: <span style="color: orange;">Medium</span>

## Example
Input: `1 -> 2 -> 3 -> 4 -> 5 -> NULL`  
Output: `1 -> 3 -> 5 -> 2 -> 4 -> NULL`

---

## Approach

### Steps:
1. **Base Case:**  
   If the list is empty (`head == null`) or contains only one node (`head.next == null`), there is no reordering required. Return the head as is.

2. **Initialize Variables:**  
   - `odd`: Points to the head of the list (odd index nodes).  
   - `even`: Points to the second node in the list (even index nodes).  
   - `headEven`: Stores the head of the even nodes list for later appending to the odd nodes list.

3. **Iterate Through the List:**  
   Use a `while` loop to traverse the list:
   - Connect `odd.next` to `odd.next.next` to skip over even nodes.  
   - Connect `even.next` to `even.next.next` to skip over odd nodes.  
   - Move the `odd` and `even` pointers to their respective next nodes.  

4. **Recombine Lists:**  
   At the end of the traversal, append the even nodes list (`headEven`) to the last odd node (`odd.next`).  

5. **Return the Result:**  
   The reordered list starts with the original `head`.

### Time Complexity
- **O(n)**: Traversing the list once, where `n` is the number of nodes.

### Space Complexity
- **O(1)**: Reordering the list in-place without using extra space.

---

## Code

```csharp
public class Solution {
    public ListNode OddEvenList(ListNode head){
        if(head == null || head.next == null) 
           return head;

        ListNode odd = head;
        ListNode even = head.next;
        ListNode headEven = even;

        while(even != null && even.next != null)
        {
            odd.next = odd.next.next;
            even.next = even.next.next;
            odd = odd.next;
            even = even.next;
        }

        odd.next = headEven;
        return head;
    }
}
