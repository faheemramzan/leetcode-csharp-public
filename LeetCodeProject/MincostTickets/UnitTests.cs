using NUnit.Framework;
namespace TestProject.MincostTickets;

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
        var days = new [] {1,4,6,7,8,20};
        var costs = new [] {2,7,15};
        var result = solution.MincostTickets(days, costs);
        Assert.That(result, Is.EqualTo(11));
    }
    
    [Test]
    public void Test2()
    {
        var days = new [] {1,2,3,4,5,6,7,8,9,10,30,31};
        var costs = new [] {2,7,15};
        var result = solution.MincostTickets(days, costs);
        Assert.That(result, Is.EqualTo(17));
    }
    
    [Test]
    public void Test3()
    {
        var days = new [] {5,6,7,8,11,12,15,16,19,20};
        var costs = new [] {2,7,15};
        var result = solution.MincostTickets(days, costs);
        Assert.That(result, Is.EqualTo(15));
    }
}