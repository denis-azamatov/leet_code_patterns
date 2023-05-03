namespace Tests;

/// <summary>
/// Given an integer array nums, handle multiple queries of the following type
/// Calculate the sum of the elements of nums between indices left and right inclusive where left less or equal right
/// Implement the NumArray class:
/// NumArray(int[] nums) Initializes the object with the integer array nums.
/// </summary>
public class Task_7_RangeSumQueryImmutable
{
    public class NumArray
    {
        readonly int[] sums;

        public NumArray(int[] nums)
        {
            sums = new int[nums.Length];
            sums[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sums[i] = nums[i] + sums[i - 1];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
                return sums[right];

            return sums[right] - sums[left - 1];
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int expected, int[] nums, int left, int right)
    {
        var numArray = new NumArray(nums);
        var res = numArray.SumRange(left, right);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] {1, new int[] {-2,0,3,-5,2,-1}, 0,2},
            new object[] {-1, new int[] {-2,0,3,-5,2,-1}, 2,5},
            new object[] {-3, new int[] {-2,0,3,-5,2,-1}, 0,5},
        };
}