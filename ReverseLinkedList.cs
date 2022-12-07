public class Solution {
    public ListNode ReverseList(ListNode head) {
        //check the status of linked list 
        if(head == null || head.next == null )
        {
            return head;
        }
        //Start variables
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp; //ends the loop

        }
        


        return prev;
        
    }
}
