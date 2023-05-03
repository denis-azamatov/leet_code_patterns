namespace Problems;

/// <summary>
/// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// </summary>
public static class Task_4_SingleNumber
{
    public static int SingleNumber(int[] nums)
    {
        return nums.Aggregate(0, (fold, num) => fold ^ num);
    }
}
