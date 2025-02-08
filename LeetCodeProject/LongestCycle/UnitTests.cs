namespace TestProject.LongestCycle;

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
        var edges = new [] {3,3,4,2,3};
        var result = solution.LongestCycle(edges);
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        var edges = new [] {2,-1,3,1};
        var result = solution.LongestCycle(edges);
        Assert.That(result, Is.EqualTo(-1));
    }
}