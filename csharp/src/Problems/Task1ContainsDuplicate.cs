namespace Problems;

public class Task1ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums) =>
        nums.Length != nums.ToHashSet().Count;
}