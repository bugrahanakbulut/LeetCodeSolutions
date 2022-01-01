/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        int tenths = 0;

        ListNode tmp1 = l1;
        ListNode tmp2 = l2;

        ListNode resultHolder = new ListNode(-1);
        ListNode iterator = resultHolder;

        while (tmp1 != null || tmp2 != null) 
        {
            int res = 0;

            if (tmp1 != null) 
            {
                res += tmp1.val;
                
                tmp1 = tmp1.next;
            }

            if (tmp2 != null) 
            {
                res += tmp2.val;
                
                tmp2 = tmp2.next;
            }

            if (tenths > 0) 
            {
                res++;
                tenths--;
            }

            if (res >= 10) 
            {
                tenths++;
                res %= 10;
            }

            iterator.next = new ListNode(res);
            iterator = iterator.next;

        }
        
        if (tenths > 0) 
        {
            iterator.next = new ListNode(1);
        }

        return resultHolder.next;
    }
}