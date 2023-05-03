using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Problems;

/// <summary>
/// Given an integer array nums, handle multiple queries of the following type
/// Calculate the sum of the elements of nums between indices left and right inclusive where left less or equal right
/// Implement the NumArray class:
/// NumArray(int[] nums) Initializes the object with the integer array nums.
/// </summary>
public class Task_7_RangeSumQueryImmutable
{
    public class NumArray
    {
        readonly int[] sums;

        public NumArray(int[] nums)
        {
            sums = new int[nums.Length];
            sums[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sums[i] = nums[i] + sums[i - 1];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0)
                return sums[right];

            return sums[right] - sums[left - 1];
        }
    }
}
