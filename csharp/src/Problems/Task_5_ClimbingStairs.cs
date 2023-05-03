using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /// <summary>
    /// You are climbing a staircase. It takes n steps to reach the top.
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// </summary>
    public static class Task_5_ClimbingStairs
    {
        public static int ClimbingStairs(int n)
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
    }
}
