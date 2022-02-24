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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode newHead = new ListNode(-1);
        ListNode headRef = newHead;

        while (list1 != null && list2 != null) 
        {
            if (list1.val < list2.val) 
            {
                newHead.next = list1;
                list1 = list1.next;
            }

            else
            {
                newHead.next = list2;
                list2 = list2.next;
            }

            newHead = newHead.next;
        }

        if (list1 != null) 
        {
            newHead.next = list1;
        }
        if (list2 != null) 
        {
            newHead.next = list2;
        }

        return headRef.next;
    }
}