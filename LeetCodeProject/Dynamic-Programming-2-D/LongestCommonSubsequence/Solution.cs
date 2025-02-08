namespace TestProject.DynamicProgramming2D.LongestCommonSubsequence;

/// <summary>
/// https://leetcode.com/problems/longest-common-subsequence/
/// </summary>
public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var m = text1.Length;
        var n = text2.Length;
        
        var matrix = new int[m+1][];
        for (var i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Enumerable.Repeat(0, n+1).ToArray();
        }

        for (var i = m-1; i >= 0; i--)
        {
            for (var j = n-1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    matrix[i][j] = 1 + matrix[i + 1][j + 1];
                }
                else
                {
                    matrix[i][j] = Math.Max(matrix[i][j + 1], matrix[i + 1][j]);
                }
            }
        }
        
        return matrix[0][0];
    }
}