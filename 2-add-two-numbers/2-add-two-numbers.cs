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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode dummy = new ListNode(0); // dummy node for storing the resulting sum node
        ListNode current = dummy; // current node which will perform operations for dummy node
        
        int carry = 0;
        
        while (l1 != null || l2 != null || carry == 1){ // checking whether either of the linked lists are not null or if carry has a 1
            
            int sum = 0;
            
            if (l1 != null){
                sum = sum + l1.val;
                l1 = l1.next;
            }
           
            if (l2 != null){
                sum = sum + l2.val;
                l2 = l2.next;
            }
            
            sum = sum + carry;
            
            carry = sum / 10;
            
            ListNode newNode = new ListNode(sum % 10);
            
            current.next = newNode;
            current = current.next;
            
        }
        
        return dummy.next;
        
    }
}