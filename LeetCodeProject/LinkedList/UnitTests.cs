namespace TestProject.LinkedList;

public class UnitTests
{
    private Solution solution = new Solution();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var list = new [] { 1,2,3,4,5 };
        var listNode = GenerateLinkedList(list);
        var result = solution.ReverseList(listNode);
        
        ListNode currentNode = result; 
        while (currentNode != null)
        {
            Console.WriteLine("VALUE: " + currentNode.Value);
            currentNode = currentNode.Next;
        }
        
    }

    private ListNode GenerateLinkedList(int[] list)
    {
        ListNode prevNode = null;
        ListNode firstNode = null;
        foreach (var value in list)
        {
            var currentNode = new ListNode(value, null);
            
            firstNode ??= currentNode; // Assign first node if NULL
            
            if (prevNode != null)
            {
                prevNode.Next = currentNode;
            }
            prevNode = currentNode;
        }

        return firstNode;
    }
}