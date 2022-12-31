using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class number03LongestSubStringWithoutRepeatingCharacters
    {
        public static int LongestSubString(string s)
        {
            if (s.Length == 1)
                return 1;

            StringBuilder sb = new StringBuilder();
            List<string> subStrings = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {       
                if (!sb.ToString().Contains(s[i]))
                {
                    sb.Append(s[i]);
                }
                else
                {
                    subStrings.Add(sb.ToString());
                    sb.Clear();
                    i = subStrings.Count - 1;

                }               
            }
            subStrings.Add(sb.ToString());

            if (subStrings.Count == 0)
                return 0;

            int maxLenthSubstring = subStrings.Max(x => x.Length);

            return maxLenthSubstring;
        }
    }
}
