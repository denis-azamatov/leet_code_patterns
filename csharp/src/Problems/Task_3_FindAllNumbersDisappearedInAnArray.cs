namespace Problems;

/// <summary>
/// Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
/// <para/>
/// Solution:
/// Invert items by index = value - 1. Than return index + 1 where value > 0.
/// </summary>
public static class Task_3_FindAllNumbersDisappearedInAnArray
{
    public static IEnumerable<int> FindDisappearedNumbers(int[] nums)
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
}