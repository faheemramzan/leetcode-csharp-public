using NUnit.Framework;
namespace TestProject.LargestRectangleArea;

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
        var heights  = new [] { 2, 1, 5, 6, 2, 3 };
        var result = solution.LargestRectangleArea(heights);
        Assert.That(result, Is.EqualTo(10));
    }
    
    [Test]
    public void Test2()
    {
        var heights = new [] { 2, 4 };
        var result = solution.LargestRectangleArea(heights);
        Assert.That(result, Is.EqualTo(4));
    }
}