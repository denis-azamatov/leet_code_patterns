namespace Problems;

/// <summary>
/// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
/// <para/>
/// Solution:
/// Sum of numbers in range [0, n] - Sum of numbers in given array
/// </summary>
public static class Task_2_MissingNumber
{
    public static int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        return n * (n + 1) / 2 - nums.Sum();
    }
}