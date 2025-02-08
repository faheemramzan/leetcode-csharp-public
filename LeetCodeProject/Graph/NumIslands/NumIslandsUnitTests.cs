namespace TestProject.Graph;

public class NumIslandsUnitTests
{
    private Solution solution = new Solution();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var grid = new [] {
            new [] {'1','1','1','1','0'},
            new [] {'1','1','0','1','0'},
            new [] {'1','1','0','0','0'},
            new [] {'0','0','0','0','0'}
        };
        var result = solution.NumIslands(grid);
        Assert.That(result, Is.EqualTo(1));
    }
    
    [Test]
    public void Test2()
    {
        var grid = new [] {
            new [] {'1','1','0','0','0'},
            new [] {'1','1','0','0','0'},
            new [] {'0','0','1','0','0'},
            new [] {'0','0','0','1','1'}
        };
        var result = solution.NumIslands(grid);
        Assert.That(result, Is.EqualTo(3));
    }
}