using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number1672RichestCustomerWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int output = 0;
            int customerNumber = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                int currentWealth = 0;

                for(int j = 0; j < accounts[i].Length; j++)
                {
                    currentWealth += accounts[i][j];
                }

                if (currentWealth> output)
                    output = currentWealth;
            }
            return output;
        }
    }
}
