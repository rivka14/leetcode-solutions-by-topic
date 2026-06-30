# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        if head is None:
            return 0

        middle = self.findMiddle(head)
        second_half = self.reverseList(middle)

        max_sum = 0
        first_half = head
        while second_half:
            max_sum = max(max_sum, first_half.val + second_half.val)
            first_half = first_half.next
            second_half = second_half.next

        return max_sum

    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev = None
        while head:
            next_node = head.next
            head.next = prev
            prev = head
            head = next_node
        return prev

    def findMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        slow, fast = head, head
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next
        return slow
