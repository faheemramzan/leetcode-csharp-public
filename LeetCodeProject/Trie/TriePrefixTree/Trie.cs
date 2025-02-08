namespace TestProject.Trie.TriePrefixTree;
/// <summary>
/// 208. Implement Trie (Prefix Tree)
/// https://leetcode.com/problems/implement-trie-prefix-tree/description/
/// </summary>
public class Trie
{
    private readonly TrieNode RootNode;
    
    public Trie()
    {
        this.RootNode = new TrieNode();
    }
    
    public void Insert(string word)
    {
        var curr = this.RootNode;

        foreach (char c in word)
        {
            if (!curr.ChildNodes.Keys.Contains(c))
            {
                curr.ChildNodes[c] = new TrieNode();
            }

            curr = curr.ChildNodes[c];
        }

        curr.IsWord = true;
    }
    
    public bool Search(string word)
    {
        var curr = this.RootNode;

        foreach (char c in word)
        {
            if (!curr.ChildNodes.Keys.Contains(c))
            {
                return false;
            }

            curr = curr.ChildNodes[c];
        }

        return curr.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        var curr = this.RootNode;

        foreach (char c in prefix)
        {
            if (!curr.ChildNodes.Keys.Contains(c))
            {
                return false;
            }

            curr = curr.ChildNodes[c];
        }

        return true;
    }
}