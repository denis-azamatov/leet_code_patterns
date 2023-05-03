namespace Problems;

/// <summary>
/// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
/// </summary>
public static class Task_8_CountingBits
{
    static int CountSetBits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }

    public static int[] CountBits(int n)
    {
        return Enumerable.Range(0, n + 1).Select(x => CountSetBits(x)).ToArray();
    }
}