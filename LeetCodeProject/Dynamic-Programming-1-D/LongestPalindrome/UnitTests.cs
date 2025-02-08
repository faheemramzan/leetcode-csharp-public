namespace TestProject.DynamicProgramming1D.LongestPalindrome;

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
        var result = solution.LongestPalindrome("babad");
        Assert.That(result, Is.EqualTo("bab"));
    }
    
    [Test]
    public void Test2()
    {
        var result = solution.LongestPalindrome("cbbd");
        Assert.That(result, Is.EqualTo("bb"));
    }
    
    [Test]
    public void Test3()
    {
        var result = solution.LongestPalindrome("ac");
        Assert.That(result, Is.EqualTo("a"));
    }
    
    [Test]
    public void Test4()
    {
        var result = solution.LongestPalindrome("abb");
        Assert.That(result, Is.EqualTo("bb"));
    }
}