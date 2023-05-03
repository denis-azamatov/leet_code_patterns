namespace Tests;

/// <summary>
/// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
/// <para/>
/// Solution:
/// Sum of numbers in range [0, n] - Sum of numbers in given array
/// </summary>
public class Task_2_MissingNumber
{
    public static int Run(int[] nums)
    {
        var n = nums.Length;
        return n * (n + 1) / 2 - nums.Sum();
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int expected, int[] nums)
    {
        var res = Run(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { 2,new[] { 3, 0, 1 } },
            new object[] { 2,new[] { 0, 1 } },
            new object[] { 8,new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 } },
        };
}