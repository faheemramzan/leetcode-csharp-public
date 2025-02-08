namespace TestProject.DynamicProgramming1D.CountSubstrings;

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
        var result = solution.CountSubstrings("abc");
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        var result = solution.CountSubstrings("aaa");
        Assert.That(result, Is.EqualTo(6));
    }
}