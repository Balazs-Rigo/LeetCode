using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Easy;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[15] { 2, 3,65,853,446,210,774,3,4,77,23,87,333,121,111 };

            #region number28
            /*
            try
            {
                int poz = number28ImplementstrStr.StrStr("babba", "bbb");
                Console.WriteLine("visszatert ertek: "+poz.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion

            #region number01
            /*
            int[] nums = new int[2] {3,3};

            int[] TwoSum = number01TwoSum.TwoSumHashTable(nums,6);
            foreach (int items in TwoSum)
            {
                Console.WriteLine("Elemek :"+ items);
            }
            */
            #endregion

            #region number07
            //number07ReverseInteger.Reverse2(12345);
            #endregion

            #region number53
            number53MaximumSubarray.MaxSubarray(nums);
            #endregion

            Console.ReadLine();
        }
    }
}
