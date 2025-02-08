using System;

namespace TestProject.Backtracking.WordSearch;

/// <summary>
/// https://leetcode.com/problems/word-search/description/
/// </summary>
public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        var rowCount = board.Length;
        var columnCount = board[0].Length;

        var set = new HashSet<Tuple<int, int>>();

        bool recursiveExist(int r, int c, int index)
        {
            Console.WriteLine($"r: {r}, c: {c}, index: {index}");
            if (index == word.Length)
                return true;
                
            var tuple = new Tuple<int, int>(r, c);
            if ((r < 0 || c < 0) || (r >= rowCount || c >= columnCount) || word[index] != board[r][c] || set.Contains(tuple))
            {
                return false;
            }

            set.Add(tuple);
            
            var result = recursiveExist(r + 1, c, index + 1) ||
                recursiveExist(r - 1, c, index + 1) ||
                recursiveExist(r, c + 1, index + 1) ||
                recursiveExist(r, c - 1, index + 1);
                
            set.Remove(tuple);
            
            return result;
        }

        for (var r = 0; r < rowCount; r++)
        {
            for (var c = 0; c < columnCount; c++)
            {   
                Console.WriteLine("------------------------");
                Console.WriteLine("----------INIT----------");
                Console.WriteLine("-----------------------");
                if (recursiveExist(r, c, 0)) return true;
            }
        }

        return false;
    }
}