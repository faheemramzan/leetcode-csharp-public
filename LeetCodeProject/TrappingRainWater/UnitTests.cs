namespace TestProject.TrappingRainWater;

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
        var height  = new [] {0,1,0,2,1,0,1,3,2,1,2,1};
        var result = solution.Trap(height);
        Assert.That(result, Is.EqualTo(6));
    }
    
    [Test]
    public void Test2()
    {
        var height  = new [] {4,2,0,3,2,5};
        var result = solution.Trap(height);
        Assert.That(result, Is.EqualTo(9));
    }
}