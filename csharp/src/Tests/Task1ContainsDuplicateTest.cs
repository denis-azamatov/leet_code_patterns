using Problems;

namespace Tests;

public class Task1ContainsDuplicateTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ContainsDuplicate(int[] nums, bool expected)
    {
        var res = new Task1ContainsDuplicate().ContainsDuplicate(nums);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new[] { 1, 2, 3, 1 }, true },
            new object[] { new[] { 1, 2, 3, 4 }, false }
        };
}