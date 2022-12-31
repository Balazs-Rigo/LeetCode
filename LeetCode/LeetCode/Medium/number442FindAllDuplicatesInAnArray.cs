using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Number442FindAllDuplicatesInAnArray
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> duplicates = new List<int>();
            Dictionary<int,int> numbers = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numbers.ContainsKey(nums[i]))
                {
                    numbers.Add(nums[i], 0);
                }
                else
                {
                    numbers[nums[i]]++;
                }
            }

            duplicates = numbers.Where(x=> x.Value == 1).Select(x => x.Key).ToList();

            return duplicates;
        }
    }
}
