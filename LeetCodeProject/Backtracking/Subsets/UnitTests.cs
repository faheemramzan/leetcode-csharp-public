namespace TestProject.Backtracking.Subsets;

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
        var nums  = new [] {1,2,3};
        var result = solution.Subsets(nums);
        Assert.That(result?.Count, Is.EqualTo(8));
    }
    
    [Test]
    public void Test2()
    {
        var nums  = new [] {0};
        var result = solution.Subsets(nums);
        Assert.That(result?.Count, Is.EqualTo(2));
    }
}