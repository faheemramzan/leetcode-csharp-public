namespace TestProject.DynamicProgramming1D.HouseRobber2;

/// <summary>
/// https://leetcode.com/problems/house-robber
/// </summary>
public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];

        return Math.Max(this.RobInternal(nums.Take(nums.Length - 1).ToArray()),
                        this.RobInternal(nums.Skip(1).ToArray()));
    }
    
    private int RobInternal(int[] nums)
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