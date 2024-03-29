﻿namespace Tests;

/// <summary>
/// You are climbing a staircase. It takes n steps to reach the top.
/// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
/// </summary>
public class Task_5_ClimbingStairs
{
    public static int Run(int n)
    {
        if (n == 1) return 1;

        var n1 = 1;
        var n2 = 2;

        for (int i = 3; i < n + 1; i++)
        {
            var temp = n1;
            n1 = n2;
            n2 = temp + n2;
        }

        return n2;
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int expected, int n)
    {
        var res = Run(n);
        Assert.Equal(res, expected);
    }

    public static IEnumerable<object[]> Data =>
        new[]
        {
            new object[] { 2, 2},
            new object[] { 1, 1},
            new object[] { 8, 5}
        };
}