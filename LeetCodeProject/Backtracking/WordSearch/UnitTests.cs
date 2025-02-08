namespace TestProject.Backtracking.WordSearch;

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
        var board   = new [] { new[] {'A','B','C','E'}, new[] {'S','F','C','S'}, new[] {'A','D','E','E'}};
        const string word = "ABCCED";
        var result = solution.Exist(board, word);
        Assert.That(result, Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        var board   = new [] { new[] {'A','B','C','E'}, new[] {'S','F','C','S'}, new[] {'A','D','E','E'}};
        const string word = "SEE";
        var result = solution.Exist(board, word);
        Assert.That(result, Is.EqualTo(true));
    }
    
    [Test]
    public void Test3()
    {
        var board   = new [] { new[] {'A','B','C','E'}, new[] {'S','F','C','S'}, new[] {'A','D','E','E'}};
        const string word = "ABCB";
        var result = solution.Exist(board, word);
        Assert.That(result, Is.EqualTo(false));
    }
}