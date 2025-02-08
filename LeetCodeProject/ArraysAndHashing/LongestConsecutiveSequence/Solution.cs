namespace TestProject.ArraysAndHashing.LongestConsecutiveSequence;

/// <summary>
/// https://leetcode.com/problems/longest-consecutive-sequence/
/// </summary>
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var numsSet = new HashSet<int>(nums);
        
        var result = 0;
        foreach (var num in nums)
        {
            if(numsSet.Contains(num-1))
                continue;

            var seqResult = 1;
            while (numsSet.Contains(num + seqResult))
            {
                seqResult++;
            }

            result = Math.Max(result, seqResult);
        }
        return result;
    }
}