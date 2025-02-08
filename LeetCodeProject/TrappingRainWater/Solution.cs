using System;

namespace TestProject.TrappingRainWater;

/// <summary>
/// https://leetcode.com/problems/trapping-rain-water/
/// </summary>
public class Solution
{
    public int Trap(int[] height)
    {
        var leftIndex = 0;
        var rightIndex = height.Length - 1;

        var maxLeftValue = height[leftIndex];
        var maxRightValue = height[rightIndex];

        var result = 0;

        while (leftIndex < rightIndex)
        {
            if (height[leftIndex] < height[rightIndex])
            {
                leftIndex++;
                maxLeftValue = Math.Max(maxLeftValue, height[leftIndex]);
                result += maxLeftValue - height[leftIndex];                
            }
            else
            {
                rightIndex--;
                maxRightValue = Math.Max(maxRightValue, height[rightIndex]);
                result += maxRightValue - height[rightIndex];              
            }
        }
        
        return result;
    }
}