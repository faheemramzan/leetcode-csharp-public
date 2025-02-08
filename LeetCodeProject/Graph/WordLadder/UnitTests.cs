namespace TestProject.Graph.WordLadder;

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
        var beginWord = "hit";
        var endWord = "cog"; 
        var wordList = new [] {"hot","dot","dog","lot","log","cog"};
        
        var result = solution.LadderLength(beginWord, endWord, wordList);
        Assert.That(result, Is.EqualTo(5));
    }
    
    [Test]
    public void Test2()
    {
        var beginWord = "hit";
        var endWord = "cog"; 
        var wordList = new [] {"hot","dot","dog","lot","log"};
        
        var result = solution.LadderLength(beginWord, endWord, wordList);
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Test3()
    {
        var beginWord = "hot";
        var endWord = "dog"; 
        var wordList = new [] {"hot","dog"};
        
        var result = solution.LadderLength(beginWord, endWord, wordList);
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void Test4()
    {
        var beginWord = "red";
        var endWord = "tax"; 
        var wordList = new [] {"ted","tex","red","tax","tad","den","rex","pee"};
        
        var result = solution.LadderLength(beginWord, endWord, wordList);
        Assert.That(result, Is.EqualTo(4));
    }
}