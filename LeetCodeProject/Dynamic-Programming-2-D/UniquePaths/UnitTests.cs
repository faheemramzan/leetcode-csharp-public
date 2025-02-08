namespace TestProject.DynamicProgramming2D.UniquePaths;

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
        var result = solution.UniquePaths(3, 7);
        Assert.That(result, Is.EqualTo(28));
    }
    
    [Test]
    public void Test2()
    {
        var result = solution.UniquePaths(3, 2);
        Assert.That(result, Is.EqualTo(3));
    }
}