namespace TestProject.Trie.WordDictionary;
/// <summary>
/// 
/// 211. Design Add and Search Words Data Structure
/// https://leetcode.com/problems/design-add-and-search-words-data-structure/description/
/// </summary>
public class WordDictionary
{
    private readonly TrieNode RootNode;
    
    public WordDictionary() {
        this.RootNode = new TrieNode();
    }
    
    public void AddWord(string word) {
        this.RootNode.AddWord(word);
    }
    
    public bool Search(string word)
    {
        return this.SearchInternal(this.RootNode, word);
    }
    
    private bool SearchInternal(TrieNode currRootNode, string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            var c = word[i];

            if (c == '.')
            {
                foreach (var childNode in currRootNode.ChildNodes)
                {
                    if (this.SearchInternal(childNode.Value, word.Substring(i + 1)))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                if (!currRootNode.ChildNodes.Keys.Contains(c))
                {
                    return false;
                }
            }

            currRootNode = currRootNode.ChildNodes[c];
        }

        return currRootNode.IsWord;
    }
}