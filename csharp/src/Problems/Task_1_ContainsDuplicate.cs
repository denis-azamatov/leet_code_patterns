namespace Problems;

/// <summary>
/// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
/// </summary>
public static class Task_1_ContainsDuplicate
{
    public static bool ContainsDuplicate(int[] nums) => nums.Length != nums.ToHashSet().Count;
}