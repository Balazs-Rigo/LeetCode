using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class number53MaximumSubArray
    {
        public static int MaxSubArrayDivideAndConquer(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        private static int Helper(int[] nums, int left,int right)
        {
            if (left == right) return nums[left];

            int p = (left + right) / 2;
            int leftSum = Helper(nums,left,p);
            int rightSum = Helper(nums, p + 1,right);
            int crossSum = CrossSum(nums,left,right,p);

            return Math.Max(Math.Max(leftSum,rightSum),crossSum);

        }

        private static int CrossSum(int[] nums, int left, int right, int p)
        {
            if (left == right) return nums[left];

            int leftSubSum = int.MinValue;
            int currSum = 0;
            for (int i = p; i > left-1; --i)
            {
                currSum += nums[i];
                leftSubSum =(Math.Max(leftSubSum,currSum));
            }

            int rightSubSum = int.MinValue;
            currSum = 0;
            for (int i = p+1; i<right + 1; ++i)
            {
                currSum += nums[i];
                rightSubSum = (Math.Max(rightSubSum, currSum));
            }

            return leftSubSum + rightSubSum;
        }

        public static int MaxSubArrayGreedy(int[] nums)
        {
            int currSum = nums[0], maxSum = nums[0];

            for (int i = 1; i < nums.Length;++i)
            {
                currSum = Math.Max(nums[i],currSum + nums[i]);
                maxSum = Math.Max(maxSum,currSum);
            }
            return maxSum;
        }

        public static int MaxSubArrayDynamicProgramming(int[] nums)
        {
            int maxSum = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i - 1] > 0)
                    nums[i] += nums[i-1];
                maxSum = Math.Max(nums[i],maxSum);
            }
            return maxSum;
        }
    }
}
