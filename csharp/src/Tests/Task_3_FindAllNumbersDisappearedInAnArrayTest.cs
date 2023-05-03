using Problems;

namespace Tests;

public class Task_3_FindAllNumbersDisappearedInAnArrayTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FindDisappearedNumbers(int[] nums, IList<int> expected)
    {
        var res = Task_3_FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 5, 6 } },
            new object[] { new[] { 1, 1 }, new[] { 2 } },
        };
}