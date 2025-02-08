using NUnit.Framework;
namespace TestProject.ArraysAndHashing.LongestConsecutiveSequence;

public class Tests
{
    private Solution solution = new Solution();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var nums  = new [] {100,4,200,1,3,2};
        var result = solution.LongestConsecutive(nums);
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void Test2()
    {
        var nums  = new [] {0,3,7,2,5,8,4,6,0,1};
        var result = solution.LongestConsecutive(nums);
        Assert.That(result, Is.EqualTo(9));
    }
}