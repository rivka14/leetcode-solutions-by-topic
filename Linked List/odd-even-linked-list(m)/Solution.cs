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
