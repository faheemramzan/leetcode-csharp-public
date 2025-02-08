using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace TestProject.DynamicProgramming1D.ClimbStairs;

/// <summary>
/// https://leetcode.com/problems/climbing-stairs/
/// https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
/// 
/// </summary>
public class Solution
{
    public int ClimbStairs(int n)
    {
    /*
        if (n == 0 || n == 1)
            return 1;

        return this.ClimbStairs(n - 1) + this.ClimbStairs(n - 2);
    */
        
        var num1 = 1;
        var num2 = 1;

        for (var i = 1; i < n; i++)
        {
            var temp = num1 + num2;
            num1 = num2;
            num2 = temp;
        }

        return num2;
    }
}