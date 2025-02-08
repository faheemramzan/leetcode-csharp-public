namespace TestProject.DynamicProgramming1D.CountSubstrings;

/// <summary>
/// https://leetcode.com/problems/palindromic-substrings/
/// </summary>
public class Solution
{
    public int CountSubstrings(string s) {
        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            this.LongestPalindromePart(s, i, i, ref result);
            this.LongestPalindromePart(s, i, i+1, ref result);
        }
        
        return result;
    }
    
    private void LongestPalindromePart(string s, int left, int right, ref int result)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            result++;
                
            left -= 1;
            right += 1;
        }
    }
}