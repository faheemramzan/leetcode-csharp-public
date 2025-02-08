namespace TestProject.Trie;

public class TrieNode
{
    public IDictionary<char, TrieNode> ChildNodes;
    public bool IsWord;
    public int ChildLinksCount = 0;
    
    public TrieNode()
    {
        this.ChildNodes = new Dictionary<char, TrieNode>();
        this.IsWord = false;
    }
    
    public void AddWord(string word) {
        var curr = this;
        this.ChildLinksCount++;
        
        foreach (char c in word)
        {
            if (!curr.ChildNodes.Keys.Contains(c))
            {
                curr.ChildNodes[c] = new TrieNode();
            }

            curr = curr.ChildNodes[c];
            curr.ChildLinksCount++;
        }

        curr.IsWord = true;
    }
    
    public void RemoveWordLink(string word) {
        var curr = this;
        curr.ChildLinksCount--;
        
        foreach (char c in word)
        {
            if (curr.ChildNodes.Keys.Contains(c))
            {
                curr = curr.ChildNodes[c];
                curr.ChildLinksCount--;
                if (curr.ChildLinksCount == 0)
                {
                    curr.ChildNodes = new Dictionary<char, TrieNode>();
                }
            }
        }
    }
}