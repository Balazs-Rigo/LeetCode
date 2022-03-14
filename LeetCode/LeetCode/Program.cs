using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using LeetCode.Easy;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[15] { 2, 3,65,401,446,-210,-774,3,4,-77,-23,87,333,121,111 };
            int[] nums = new int[] {1,2,3,4};
            string[] numString = new string[] {"--X","++X","++X","++X","--XX"};
            int[][] arraysOfNums = new int[][] {
                                                    new int[] { 1, 3, 5, 7, 9 },
                                                    new int[] { 0, 2, 4, 6 },
                                                    new int[] { 11, 22 }
                                                    };
            Random randNum = new Random();
            int[] numsRandom = Enumerable.Repeat(0, 5000000).Select(i =>randNum.Next(-100,100)).ToArray();

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
            var watch = new Stopwatch();
            watch.Start();
            var maxSubArrayDivideAndConquer = number53MaximumSubArray.MaxSubArrayDivideAndConquer(numsRandom);
            Console.WriteLine(watch.Elapsed);
            watch.Restart();
            var maxSubArrayGreedy = number53MaximumSubArray.MaxSubArrayGreedy(numsRandom);
            Console.WriteLine(watch.Elapsed);
            watch.Restart();
            var maxSubArrayDynamicProgramming = number53MaximumSubArray.MaxSubArrayDynamicProgramming(numsRandom);
            Console.WriteLine(watch.Elapsed);
            watch.Restart();
            watch.Stop();
            #endregion

            #region number268

            //int missingNumber = number268MissingNumber.MissingNumber4(nums);

            //Console.WriteLine("missing number: "+missingNumber);

            #endregion

            #region number1929

            number1929ConcatenationOfArray.GetConcatenation(nums);

            #endregion

            #region number1480

            //number1480RunningSumOf1dArray.RunningSum(nums);

            #endregion

            #region number2011

            //number2011FinalValueOfVariableAfterPerformingOperations.FinalValueAfterOperations(numString);

            #endregion

            #region number1672

            number1672RichestCustomerWealth.MaximumWealth(arraysOfNums);

            #endregion


            //Console.WriteLine(maxSubArrayGreedy);
            //Console.WriteLine(maxSubArrayDivideAndConquer); 
            //Console.WriteLine(maxSubArrayDynamicProgramming);
            Console.ReadLine();
        }
    }
}
