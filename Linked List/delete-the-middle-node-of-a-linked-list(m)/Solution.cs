public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        if (head == null || head.next == null)
            return null;

        ListNode slow = new ListNode();
        slow.next = head;
        ListNode fast = head;

        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode node = slow.next;
        slow.next = slow.next.next;
        DeleteNode(node);   
        return head;
    }
  
    public void DeleteNode(ListNode node) {
        node.next = null;
    }
}
