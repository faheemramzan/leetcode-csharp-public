using NUnit.Framework;
namespace TestProject.MakeConnected;

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
        int n = 4;
        int[][] connections = { new [] {0,1},new [] {0,2},new [] {1,2}};
        int result = solution.MakeConnected(n, connections);
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Test2()
    {
        int n = 6;
        int[][] connections = {new [] {0,1},new [] {0,2},new [] {0,3},new [] {1,2},new [] {1,3}};
        int result = solution.MakeConnected(n, connections);
        Assert.That(result, Is.EqualTo(2));
    }
}