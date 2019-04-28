using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class number28ImplementstrStr
    {
        public static int StrStr(string haystack, string needle)
        {
            bool isStillEqual = true;
            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i] == needle[i])
                    {

                    }                    
                }
                
            }

            return 0;
        }
    }
}
