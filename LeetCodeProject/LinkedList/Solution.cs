namespace TestProject.LinkedList;

/// <summary>
/// https://leetcode.com/problems/reverse-linked-list/
/// </summary>
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode currNode = head;
        ListNode prevNode = null;
    
        while (currNode != null) {
            var nextCurrNode = currNode.Next;
            currNode.Next = prevNode;
            prevNode = currNode;
            currNode = nextCurrNode;
        }

        return prevNode;
    }
}