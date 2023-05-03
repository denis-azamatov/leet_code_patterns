namespace Tests;

/// <summary>
/// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
/// </summary>
public class Task_1_ContainsDuplicate
{
    public static bool Run(int[] nums) => nums.Length != nums.ToHashSet().Count;

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(bool expected, int[] nums)
    {
        var res = Run(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] {true, new[] { 1, 2, 3, 1 } },
            new object[] {false, new[] { 1, 2, 3, 4 } }
        };
}