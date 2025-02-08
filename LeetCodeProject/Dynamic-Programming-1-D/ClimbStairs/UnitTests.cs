namespace TestProject.DynamicProgramming1D.ClimbStairs;

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
        var result = solution.ClimbStairs(2);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Test2()
    {
        var result = solution.ClimbStairs(3);
        Assert.That(result, Is.EqualTo(3));
    }
}