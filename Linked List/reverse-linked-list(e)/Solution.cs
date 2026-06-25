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
