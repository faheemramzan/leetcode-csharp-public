namespace TestProject.HeapOrPriorityQueue;

public class MedianFinderUnitTests
{
    [Test]
    public void Test1()
    {
        MedianFinder medianFinder = new MedianFinder();
        medianFinder.AddNum(1);    // arr = [1]
        medianFinder.AddNum(2);    // arr = [1, 2]
        var result = medianFinder.FindMedian(); // return 1.5 (i.e., (1 + 2) / 2)
        Assert.That(result, Is.EqualTo(1.5));
        
        medianFinder.AddNum(3);    // arr[1, 2, 3]
        result = medianFinder.FindMedian(); // return 2.0
        Assert.That(result, Is.EqualTo(2));
    }
}