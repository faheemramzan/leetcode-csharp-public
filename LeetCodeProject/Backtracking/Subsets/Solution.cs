using System;

namespace TestProject.Backtracking.Subsets;

/// <summary>
/// https://leetcode.com/problems/subsets/
/// </summary>
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();
        var subset = new List<int>();
        this.SubsetsDFS(nums, 0, result, subset);
        return result;
    }
    
    private void SubsetsDFS(int[] nums, int index, IList<IList<int>> result, IList<int> subset)
    {
        if (index >= nums.Length)
        {
            Console.WriteLine($"Final subset: [{string.Join(',', subset.ToArray())}]");
            Console.WriteLine("------------------------------------");
            result.Add(subset.Select(row => row).ToList());
            return;
        }
        
        Console.WriteLine($"index: {index} num: {nums[index]}");
        subset.Add(nums[index]);
        this.SubsetsDFS(nums, index + 1, result, subset);
       
        Console.WriteLine($"POP: {subset[subset.Count - 1]} index: {index} num: {nums[index]}");
        subset.RemoveAt(subset.Count - 1);
        this.SubsetsDFS(nums, index + 1, result, subset);
    }
}