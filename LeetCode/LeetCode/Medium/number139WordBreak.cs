using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class number139WordBreak
    {
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            var result1 = string.Empty;
            var result3 = string.Empty;
            var result4 = string.Empty;
            var temp1 = s;
            var temp2 = s;
            var temp3 = s;
            var temp4 = s;
            var orderedWordDict = wordDict.OrderBy(w => w.Length).ToList();
            var orderedWordABC = wordDict.OrderBy(w => w).ToList();
            var orderedWordABCDict = wordDict.OrderBy(w => w).ToList();

            foreach (string word in orderedWordDict)
            {
                result1 = temp1.Replace(word, " ");
                temp1 = result1;
            }

            var result2 = string.Empty;


            if (!string.IsNullOrWhiteSpace(result1))
            {
                var orderedWordDictDesc = wordDict.OrderByDescending(w => w.Length).ToList();
                foreach (string word in orderedWordDictDesc)
                {
                    result2 = temp2.Replace(word, " ");
                    temp2 = result2;
                }
            }

            if (!string.IsNullOrWhiteSpace(result2))
            {
                foreach (string word in orderedWordABC)
                {
                    result3 = temp3.Replace(word, " ");
                    temp3 = result3;
                }
            }

            if (!string.IsNullOrWhiteSpace(result3))
            {
                foreach (string word in orderedWordABC)
                {
                    result4 = temp4.Replace(word, " ");
                    temp4 = result4;
                }
            }

            

            if (string.IsNullOrWhiteSpace(result4))
                return true;

            return false;
        }
    }
}
