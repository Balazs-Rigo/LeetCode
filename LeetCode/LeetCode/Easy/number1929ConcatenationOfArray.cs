using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number1929ConcatenationOfArray
    {
        public static int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length*2];
            nums.CopyTo(ans, 0);
            nums.CopyTo(ans, nums.Length);

            return ans;
        }
    }
}
