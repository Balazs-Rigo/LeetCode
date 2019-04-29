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
            Console.WriteLine("needle.lenght : "+needle.Length);
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < haystack.Length-needle.Length+1; i++)
            {
                for (int j= 0; j < needle.Length; j++)
                {
                    if (haystack[j+i]==needle[j])
                    {
                        count++;
                        Console.WriteLine();
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                    if (count == needle.Length)
                    {
                        Console.WriteLine("count erteke, talalt elott. " +
                            "Ami, ha megegyezik needle-lenght-tel, akkor talalt: " + count);
                        return i;
                    }
                }                
            }
            Console.WriteLine("count erteke, ha nem talalt: "+count);
            return -1;
        }
    }
}
