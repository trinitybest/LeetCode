/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 * A few things to pay attentation to:
  - use a dummy head is a good choice
  - one list may be much longer than the other one
  - take good care of levelUp
  - Don't mess with % and /
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode first = l1;
        ListNode second = l2;
        int v = 0;
        int levelUp = 0;
        ListNode head = new ListNode(0);
        ListNode temp = head;
        int p, q = 0;
        while(first!=null || second!=null)
        {
            if(first==null&&second!=null)
            {
                p = 0;
                q = second.val;
                second = second.next;
            }
            else if(first!=null&&second==null)
            {
                p = first.val;
                q = 0;
                first = first.next;

            }
            else
            {
                p = first.val;
                q = second.val;
                first = first.next;
                second = second.next;
            }
            v = (p+q+levelUp) % 10;
            levelUp = (p+q+levelUp) / 10;
            temp.next = new ListNode(v);
            temp = temp.next;
            
        }
        
        if(levelUp != 0)
            {
                temp.next = new ListNode(levelUp);
            }
            
        return head.next;
    }
}








