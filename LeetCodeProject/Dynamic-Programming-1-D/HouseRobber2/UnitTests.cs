namespace TestProject.DynamicProgramming1D.HouseRobber2;

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
        var nums = new [] { 2,3,2 };
        var result = solution.Rob(nums);
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        var nums = new [] { 1,2,3 };
        var result = solution.Rob(nums);
        Assert.That(result, Is.EqualTo(3));
    }
}