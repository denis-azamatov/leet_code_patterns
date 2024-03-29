﻿namespace Tests;

/// <summary>
/// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
/// </summary>
public class Task_8_CountingBits
{
    public static int[] Run(int n)
    {
        return Enumerable.Range(0, n + 1).Select(x => CountSetBits(x)).ToArray();
    }

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

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] expected, int n)
    {
        var res = Run(n);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { new int[] { 0, 1, 1 }, 2},
            new object[] { new int[] { 0, 1, 1, 2, 1, 2 }, 5 },
        };
}