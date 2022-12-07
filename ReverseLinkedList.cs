public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null )
        {
            return head;
        }
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null)
        {
            ListNode post = curr.next;
            curr.next = prev;
            prev = curr;
            curr = post;

        }
        


        return prev;
        
    }
}
