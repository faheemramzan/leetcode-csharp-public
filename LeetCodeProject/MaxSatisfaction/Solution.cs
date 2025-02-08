namespace TestProject.MaxSatisfaction;

/// <summary>
/// https://leetcode.com/problems/reducing-dishes/
/// </summary>
public class Solution
{
    public int MaxSatisfaction(int[] satisfaction)
    {
        Array.Sort(satisfaction);

        var maxSatisfaction = 0;
        var totalSum = 0;
        for (var index = satisfaction.Length - 1; index >= 0; index--)
        {
            var totalSumUpToIndex = totalSum + satisfaction[index];
            // Break the look if the result become zero or less.
            if (totalSumUpToIndex <= 0)
                break;

            // Total sum so far all dishes.
            totalSum = totalSumUpToIndex;
            
            //Add total sum from previous dishes again to get the "Like-time coefficient" of all dishes 
            maxSatisfaction += totalSum;
        }
        
        return maxSatisfaction;
    }
}