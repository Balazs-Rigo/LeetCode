using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number1480RunningSumOf1dArray
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] output = new int[nums.Length];
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = nums[i]+currentSum;
                currentSum += nums[i];
            }
            return output;
        }
    }
}
