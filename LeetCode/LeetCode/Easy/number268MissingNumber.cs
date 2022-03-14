using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number268MissingNumber
    {
        public static int MissingNumber(int[] nums)
        {
            int output = 0;

            Array.Sort(nums);

            if (nums[0] != 0)
                return 0;

            for (int i = 0; i < nums.Length-1; i++)
            {

                if (nums[i + 1] != nums[i] + 1)
                    return output = nums[i] + 1;
            }

            return nums[nums.Length-1]+1;

        }

        public static int MissingNumber2(int[] nums)
        {
            int[] numsOrdered = new int[nums.Length+1];

            for (int i = 0; i <= nums.Length; i++)
            {
                numsOrdered[i] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if ( !nums.Contains(numsOrdered[i]))
                    return numsOrdered[i];
            }

            return numsOrdered[numsOrdered.Length-1];
        }

        public static int MissingNumber3(int[] nums)
        {
            int[] numsOrdered = new int[nums.Length + 1];
            //List<int> missingNumber = new List<int>();

            for (int i = 0; i <= nums.Length; i++)
            {
                numsOrdered[i] = i;
            }


            var missingNumber = numsOrdered.Except(nums);

            return missingNumber.First();
            
        }

        public static int MissingNumber4(int[] nums)
        {
            var range = Enumerable.Range(0, nums.Length+1); 
            
            return range.Except(nums).First();
        }
    }
}
