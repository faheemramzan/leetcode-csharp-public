namespace TestProject.FindMedianSortedArrays;

/// <summary>
/// https://leetcode.com/problems/median-of-two-sorted-arrays/
/// </summary>
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {        
        int[] nums = new int[nums1.Length + nums2.Length];
        int index = 0;
        int x=0, y=0;
        while(x<nums1.Length || y<nums2.Length) {
            if(x >= nums1.Length)
                nums[index++] = nums2[y++];
            else if(y >= nums2.Length)
                nums[index++] = nums1[x++];
            else {
                if(nums1[x] < nums2[y]){
                    nums[index++] = nums1[x++];
                }
                else if(nums2[y] < nums1[x]){
                    nums[index++] = nums2[y++];
                }
                else{
                    nums[index++] = nums1[x++];
                    nums[index++] = nums2[y++];
                }
            }                       
        }
        
        if(nums.Length % 2 == 0){
            int mIndex = nums.Length / 2;
            return (nums[mIndex-1] + nums[mIndex])/2.0;
        }
        else {
            int mIndex = (int)Math.Floor(nums.Length / 2.0);
            return nums[mIndex];
        }
    }
}