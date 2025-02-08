namespace TestProject.DynamicProgramming1D.HouseRobber;

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
        var nums = new [] { 1, 2, 3, 1 };
        var result = solution.Rob(nums);
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void Test2()
    {
        var nums = new [] { 2,7,9,3,1 };
        var result = solution.Rob(nums);
        Assert.That(result, Is.EqualTo(12));
    }
}