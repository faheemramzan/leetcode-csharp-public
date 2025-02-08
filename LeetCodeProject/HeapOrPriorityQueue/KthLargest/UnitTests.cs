namespace TestProject.HeapOrPriorityQueue;

public class UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var kthLargest = new KthLargest(3, new [] {4, 5, 8, 2});
        kthLargest.Add(3);   // return 4
        kthLargest.Add(5);   // return 5
        kthLargest.Add(10);  // return 5
        kthLargest.Add(9);   // return 8
        kthLargest.Add(4);   // return 8
    }
}