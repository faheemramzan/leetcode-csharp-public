namespace TestProject.Graph.WordLadder;

/// <summary>
/// https://leetcode.com/problems/word-ladder/
/// </summary>
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord))
            return 0;

        var neighbourDict = this.GetNeighbourDict(beginWord, wordList);
        
        var visited = new HashSet<string> { beginWord };
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);

        var result = 1;
        while (queue.Count > 0)
        {
            var count = queue.Count;
            for (int qi = 0; qi < count; qi++)
            {
                var word = queue.Dequeue();
                Console.WriteLine(word);
                if (string.Equals(word, endWord))
                {
                    return result;
                }
                
                for (int i = 0; i < word.Length; i++)
                {
                    var pattern = $"{word.Substring(0, i)}*{word.Substring(i + 1)}";
                    foreach (var neighbourWord in neighbourDict[pattern])
                    {
                        if (!visited.Contains(neighbourWord))
                        {
                            Console.WriteLine($"neighbourWord: {neighbourWord}");
                            queue.Enqueue(neighbourWord);
                            visited.Add(neighbourWord);
                        }
                    }
                }
            }

            result++;
        }

        return 0;
    }

    private IDictionary<string, List<string>> GetNeighbourDict(string beginWord, IList<string> wordList)
    {
        var neighbourDict = new Dictionary<string, List<string>>();
        foreach (var word in wordList.Prepend(beginWord))
        {
            for (int i = 0; i < word.Length; i++)
            {
                var pattern = $"{word.Substring(0, i)}*{word.Substring(i + 1)}";
                if (!neighbourDict.ContainsKey(pattern))
                {
                    neighbourDict[pattern] = new List<string>();
                }
                neighbourDict[pattern].Add(word);
            }
        }

        return neighbourDict;
    }
}