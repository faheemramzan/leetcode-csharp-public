using NUnit.Framework;
namespace TestProject.FindMedianSortedArrays;

public class Tests
{
    private Solution solution = new Solution();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var nums1 = new [] {1,3};
        var nums2 = new [] {2};
        double result = solution.FindMedianSortedArrays(nums1, nums2);
        Assert.That(result, Is.EqualTo(2.00000));
    }
    
    [Test]
    public void Test2()
    {
        var nums1 = new [] {1,2};
        var nums2 = new [] {3,4};
        double result = solution.FindMedianSortedArrays(nums1, nums2);
        Assert.That(result, Is.EqualTo(2.50000));
    }
}