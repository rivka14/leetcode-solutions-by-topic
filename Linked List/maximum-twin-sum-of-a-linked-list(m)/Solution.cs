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
