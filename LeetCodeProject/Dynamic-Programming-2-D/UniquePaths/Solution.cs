namespace TestProject.DynamicProgramming2D.UniquePaths;

/// <summary>
/// https://leetcode.com/problems/palindromic-substrings/
/// </summary>
public class Solution
{
    public int UniquePaths(int m, int n)
    {
       var rowResult = Enumerable.Repeat(1, n).ToArray();
        for (var i = 0; i < m - 1; i++)
        {
            var currentRowResult = new int[n];
            currentRowResult[n - 1] = 1;
            for (var j = n - 2; j >= 0; j--)
            {
                currentRowResult[j] = rowResult[j] + currentRowResult[j + 1];
            }

            rowResult = currentRowResult;
        }
        return rowResult[0];
    }
}