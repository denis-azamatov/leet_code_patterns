namespace Tests;

/// <summary>
/// Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
/// <para/>
/// Solution:
/// Invert items by index = value - 1. Than return index + 1 where value > 0.
/// </summary>
public class Task_3_FindAllNumbersDisappearedInAnArray
{
    public static IEnumerable<int> Run(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var j = Math.Abs(nums[i]) - 1;
            nums[j] = -Math.Abs(nums[j]);
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                yield return i + 1;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] expected, int[] nums)
    {
        var res = Run(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new[] { 5, 6 } , new[] { 4, 3, 2, 7, 8, 2, 3, 1 }},
            new object[] { new[] { 2 },new[] { 1, 1 }},
        };
}