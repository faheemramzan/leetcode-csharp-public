namespace TestProject.Recursion.Exponentiation;

public class UnitTests
{
    private Solution solution = new Solution();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
       var result = solution.Pow(2, 5);
       Console.WriteLine("result: " + result);
        Assert.That(result, Is.EqualTo(32));
    }
}