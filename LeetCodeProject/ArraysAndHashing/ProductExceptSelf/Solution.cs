namespace LeetCodeProject.ArraysAndHashing.ProductExceptSelf;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefix = 1;
        var postfix = 1;
        var res = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }

        for (var i = nums.Length-1; i >= 0; i--)
        {
            res[i] *= postfix;
            postfix *= nums[i];
        }

        return res;
    }
}