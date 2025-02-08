using NUnit.Framework;

namespace TestProject.CharacterReplacement;

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
        const string s = "ABAB";
        const int k = 2;
        var result = solution.CharacterReplacement(s, k);
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void Test2()
    {
        const string s = "AABABBA";
        const int k = 1;
        var result = solution.CharacterReplacement(s, k);
        Assert.That(result, Is.EqualTo(4));
    }
    
    [Test]
    public void Test3()
    {
        const string s = "ABAA";
        const int k = 0;
        var result = solution.CharacterReplacement(s, k);
        Assert.That(result, Is.EqualTo(2));
    }
}