namespace TestProject.Trie.FindWords;
/// <summary>
/// 
/// 212. Word Search II
/// https://leetcode.com/problems/word-search-ii/
/// </summary>
public class Solution
{
    public IList<string> FindWords(char[][] board, string[] words) {

        var rootNode = new TrieNode();
        foreach (var word in words)
        {
            rootNode.AddWord(word);
        }
        
        var rowCount = board.Length;
        var columnCount = board[0].Length;

        var result = new List<string>();
        var set = new HashSet<Tuple<int, int>>();

        void recursiveExist(int r, int c, TrieNode node, string word)
        {
            var tuple = new Tuple<int, int>(r, c);
            var cKey = board[r][c];
            if ((r < 0 || c < 0) || 
                (r >= rowCount || c >= columnCount) || 
                !node.ChildNodes.ContainsKey(cKey) || 
                node.ChildNodes[cKey].ChildLinksCount <= 0 ||
                set.Contains(tuple))
            {
                return;
            }

            set.Add(tuple);
            node = node.ChildNodes[cKey];
            word += cKey;
            if (node.IsWord)
            {
                result.Add(word);
                
                node.IsWord = false;
                rootNode.RemoveWordLink(word);
            }
            
            recursiveExist(r + 1, c, node, word);
            recursiveExist(r - 1, c, node, word);
            recursiveExist(r, c + 1, node, word);
            recursiveExist(r, c - 1, node, word);
                
            set.Remove(tuple);
        }

        for (var r = 0; r < rowCount; r++)
        {
            for (var c = 0; c < columnCount; c++)
            {   
                recursiveExist(r, c, rootNode, string.Empty);
            }
        }

        return result;
    }
    
    public static string findNumber(List<int> arr, int k)
    {
        var left = 0;
        var right = arr.Count - 1;
        while (left < right)
        {
            if (arr[left] == k || arr[right] == k) return "YES";
            
            left++;
            right--;
        }

        return "NO";
    }
    
    public static List<int> oddNumbers(int l, int r)
    {
        SortedSet<int> result = new SortedSet<int>();
        
        var left = l;
        var right = r;
        while (left < right)
        {
            if (left % 2 == 1) result.Add(left);
            
            if (right % 2 == 1) result.Add(right);
            
            left++;
            right--;
        }

        return result.ToList();
    }
}