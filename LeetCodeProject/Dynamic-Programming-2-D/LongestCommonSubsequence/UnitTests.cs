namespace TestProject.DynamicProgramming2D.LongestCommonSubsequence;

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
        var result = solution.LongestCommonSubsequence("abcde", "ace");
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        var result = solution.LongestCommonSubsequence("abc", "abc");
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    public void Test3()
    {
        var result = solution.LongestCommonSubsequence("abc", "def");
        Assert.That(result, Is.EqualTo(0));
    }
}