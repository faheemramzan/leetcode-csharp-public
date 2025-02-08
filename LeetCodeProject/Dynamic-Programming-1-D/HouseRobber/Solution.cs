namespace TestProject.DynamicProgramming1D.HouseRobber;

/// <summary>
/// https://leetcode.com/problems/house-robber
/// </summary>
public class Solution
{
    public int Rob(int[] nums)
    {
        var prevRobAmount = 0;
        var currRobAmount = 0;
        foreach (var n in nums)
        {
            var temp = Math.Max(n + prevRobAmount, currRobAmount);
            prevRobAmount = currRobAmount;
            currRobAmount = temp;
        }
        return currRobAmount;
    }
}