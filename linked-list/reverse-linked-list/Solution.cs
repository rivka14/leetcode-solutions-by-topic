public class Solution {
    public ListNode ReverseList(ListNode head) {

        // If the list is empty or contains only one node, no need to reverse it
        if(head == null || head.next == null)
            return head;

        ListNode nextTemp = head.next, reverseHead = null;

        // Reversing the list
        while(head != null)
        {
            nextTemp = head.next;  // Store the next node
            head.next = reverseHead;  // Link the current node to the previous node
            reverseHead = head;  // Update the new head of the reversed list
            head = nextTemp;  // Move to the next node
        }

        return reverseHead;  // Return the new head of the reversed list
    }
}
