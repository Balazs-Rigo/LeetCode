using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number2011FinalValueOfVariableAfterPerformingOperations
    {
        public static int FinalValueAfterOperations(string[] operations)
        {
            int output = 0;

            string addOperatorPost = "X++";
            string addOperatorPre = "++X";
            string subOperatorPost = "X--";
            string subOperatorPre = "--X";

            foreach (string item in operations)
            {
                if (item == "X++" || item == "++X")
                    output += 1;
                else
                    output -= 1;
            }

            return output;
        }
    }
}
