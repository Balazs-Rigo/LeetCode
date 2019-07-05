using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number01TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];
            
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j]== target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return indices;
        }

        public static int[] TwoSumHashTable(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i],i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement)&& map[complement] != i)
                {
                    return new int[] {i, map[complement] };
                }
            }
            throw new ArgumentException("No two sum solution");
        }

        public static int[] TwoSumOnePassDictionary(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            result[0] = -1;
            result[1] = -1;
            if (nums == null || nums.Length == 0)
            {
                return result;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int otherNum = target - nums[i];
                if (dict.ContainsKey(otherNum))
                {
                    result[0] = dict[otherNum];
                    result[1] = i;
                    return result;
                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
