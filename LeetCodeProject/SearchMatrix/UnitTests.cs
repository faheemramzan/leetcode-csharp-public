namespace TestProject.SearchMatrix;

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
        var matrix   = new [] {new []{1,3,5,7},new []{10,11,16,20},new []{23,30,34,60}};
        const int target = 3;
        var result = solution.SearchMatrix(matrix, target);
        Assert.That(result, Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        var matrix   = new [] {new []{1,3,5,7},new []{10,11,16,20},new []{23,30,34,60}};
        const int target = 13;
        var result = solution.SearchMatrix(matrix, target);
        Assert.That(result, Is.EqualTo(false));
    }
}