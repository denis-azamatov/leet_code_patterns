namespace Problems;

public class Task2MissingNumber
{
    public int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        return n * (n + 1) / 2 - nums.Sum();
    }
}