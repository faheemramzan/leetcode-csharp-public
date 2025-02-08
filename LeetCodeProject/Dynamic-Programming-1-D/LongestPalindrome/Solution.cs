namespace TestProject.DynamicProgramming1D.LongestPalindrome;

/// <summary>
/// https://leetcode.com/problems/longest-palindromic-substring/
/// </summary>
public class Solution
{
    public string LongestPalindrome(string s)
    {
        var result = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            this.LongestPalindromePart(s, i, i, ref result);
            this.LongestPalindromePart(s, i, i+1, ref result);
        }
        
        return result;
    }
    
    private void LongestPalindromePart(string s, int left, int right, ref string result)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            var currResultLength = right - left + 1;
            if(currResultLength > result.Length)
                result = s.Substring(left, currResultLength);
            left -= 1;
            right += 1;
        }
    }
}