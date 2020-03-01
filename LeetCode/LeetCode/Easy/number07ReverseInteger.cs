using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class number07ReverseInteger
    {
        public static int Reverse(int x)
        {
            string number = x.ToString();
            StringBuilder sb = new StringBuilder();

            char[] numberArray = new char[number.Length];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = number[i];
            }
            char[] reversedNumberArray = new char[number.Length];

            for (int i = numberArray.Length; i > 0; i--)
            {
                reversedNumberArray[i] = numberArray[i];
            }

            for (int i = 0; i < reversedNumberArray.Length; i++)
            {
                sb.Append(reversedNumberArray[i].ToString());
            }

            return int.Parse(sb.ToString());
          
        }

        public static int Reverse2(int number)
        {
            int reverse = 0;
            var stringBuilder = new StringBuilder();

            while (number > 0)
            {
                reverse = number % 10;
                stringBuilder.Append(reverse);
                Console.Write(reverse);
                number = number / 10;
            }
            return int.Parse(stringBuilder.ToString());
        }
    }
}
