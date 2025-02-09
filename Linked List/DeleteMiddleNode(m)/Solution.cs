public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        // If the list is empty or has only one node, return null
        if (head == null || head.next == null)
            return null;
        // Pointer slow starts from the head
        ListNode slow = new ListNode();
        slow.next = head;
        // Pointer fast starts from the head 
        ListNode fast = head;
        // Move slow pointer one step at a time and fast pointer two steps
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        // Skip the middle node by pointing the previous node to the next node
        ListNode node = slow.next;
        slow.next = slow.next.next;
        // Explicitly delete the node from memory
        DeleteNode(node);   
        return head;
    }
  
    // Verify deletion of the node from memory (If it is necessary)
    public void DeleteNode(ListNode node) {
        node.next = null;
    }
}
