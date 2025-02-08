using NUnit.Framework;
namespace TestProject.MaxSatisfaction;

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
        var satisfaction  = new [] {-1,-8,0,5,-9};
        var result = solution.MaxSatisfaction(satisfaction);
        Assert.That(result, Is.EqualTo(14));
    }
    
    [Test]
    public void Test2()
    {
        var satisfaction  = new [] {4,3,2};
        var result = solution.MaxSatisfaction(satisfaction);
        Assert.That(result, Is.EqualTo(20));
    }
    
    [Test]
    public void Test3()
    {
        var satisfaction  = new [] {-1,-4,-5};
        var result = solution.MaxSatisfaction(satisfaction);
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Test4()
    {
        var satisfaction  = new [] {-3,-1,-8,0,5,-9};
        var result = solution.MaxSatisfaction(satisfaction);
        Assert.That(result, Is.EqualTo(15));
    }
}