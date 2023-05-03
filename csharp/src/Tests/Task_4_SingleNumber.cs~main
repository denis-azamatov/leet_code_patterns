namespace Tests;

/// <summary>
/// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// </summary>
public class Task_4_SingleNumber
{
    public static int Run(int[] nums)
    {
        return nums.Aggregate(0, (fold, num) => fold ^ num);
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
            new object[] { 1,new[] { 2,2,1 }},
            new object[] { 4,new[] { 4, 1, 2, 1, 2 }},
            new object[] { 1,new[] { 1 }}
        };
}