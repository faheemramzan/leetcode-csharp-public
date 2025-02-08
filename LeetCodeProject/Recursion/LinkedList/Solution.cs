namespace TestProject.Recursion.LinkedList;

/// <summary>
/// https://leetcode.com/problems/reverse-linked-list/
/// </summary>
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        return ReverseListRecursive(head, null);
    }
    
    private ListNode ReverseListRecursive(ListNode currNode, ListNode prevNode) {
        Console.WriteLine("currNode: " + currNode?.Value);
        Console.WriteLine("prevNode: " + prevNode?.Value);
        Console.WriteLine("-------------------------------");
        
        if (currNode == null) return prevNode;
        var nextCurrNode = currNode.Next;
        currNode.Next = prevNode;
        return ReverseListRecursive(nextCurrNode, currNode);
    }
}