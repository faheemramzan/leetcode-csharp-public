namespace TestProject.CharacterReplacement;

/// <summary>
/// https://leetcode.com/problems/longest-repeating-character-replacement/
/// </summary>
public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var result = 0;
        var left = 0;
        var right = 0;

        var countDict = new Dictionary<char, int>();
        for (right=0; right<s.Length; right++)
        {
            if (!countDict.ContainsKey(s[right]))
            {
                countDict[s[right]] = 0;
            }
            countDict[s[right]] += 1;
            
            while (this.getWindowSize(left, right) - countDict.Max(row => row.Value) > k)
            {
                countDict[s[left]] -= 1;
                left++;
            }
            
            result = Math.Max(result, this.getWindowSize(left, right));
        }
        
        return result;
    }

    private int getWindowSize(int left, int right)
    {
        return right - left + 1;
    }
}