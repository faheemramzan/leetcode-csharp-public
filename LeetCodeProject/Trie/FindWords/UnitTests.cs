namespace TestProject.Trie.FindWords;

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
        var board   = new [] { new[] {'o','a','a','n'}, new[] {'e','t','a','e'}, new[] {'i','h','k','r'}, new[] {'i','f','l','v'}};
        var words = new [] { "oath","pea","eat","rain" };
        var result = solution.FindWords(board, words);
        Assert.That(result[0], Is.EqualTo("oath"));
        Assert.That(result[1], Is.EqualTo("eat"));
    }
    
    [Test]
    public void Test2()
    {
        var board   = new [] { new [] {'a','b'}, new[] {'a','b'}};
        var words = new [] { "abcb" };
        var result = solution.FindWords(board, words);
        Assert.That(result.Count, Is.EqualTo(0));
    }
    
    [Test]
    public void Test3()
    {
        var board   = new [] { new [] {'o','a','b','n'}, new[] {'o','t','a','e'}, new[] {'a','h','k','r'}, new[] {'a','f','l','v'}};
        var words = new [] { "oa","oaa" };
        var result = solution.FindWords(board, words);
        
        Assert.That(result[0], Is.EqualTo("oa"));
        Assert.That(result[1], Is.EqualTo("oaa"));
    }
    
    [Test]
    public void Test4()
    {
        var board   = new [] { new [] {'o','a','a','n'}, new[] {'e','t','a','e'}, new[] {'i','h','k','r'}, new[] {'i','f','l','v'}};
        var words = new [] { "oath","pea","eat","rain","hklf", "hf" };
        var result = solution.FindWords(board, words);
        
        Assert.That(result[0], Is.EqualTo("oath"));
        Assert.That(result[1], Is.EqualTo("eat"));
        Assert.That(result[2], Is.EqualTo("hf"));
        Assert.That(result[3], Is.EqualTo("hklf"));

    }
}