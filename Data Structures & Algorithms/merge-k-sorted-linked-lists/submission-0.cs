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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        var pq = new PriorityQueue<ListNode, int>();

        // Add the head of each list into the priority queue
        foreach (var node in lists)
        {
            if (node != null)
            {
                pq.Enqueue(node, node.val);
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (pq.Count > 0)
        {
            var smallest = pq.Dequeue();
            tail.next = smallest;
            tail = tail.next;

            if (smallest.next != null)
            {
                pq.Enqueue(smallest.next, smallest.next.val);
            }
        }

        return dummy.next;
    }
}
