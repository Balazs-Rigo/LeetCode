using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Number02AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            StringBuilder sb1= new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            while (l1 != null)
            {
                sb1.Append(l1.val.ToString());
                l1 = l1.next;
            }

            while (l2 != null)
            {
                sb2.Append(l2.val.ToString());
                l2 = l2.next;
            }

            int vmi = 999999991+9;
            int vmi2 = int.MaxValue;
            int.TryParse(sb1.ToString(), out int number1);
            int.TryParse(sb2.ToString(), out int number2);

            number1 = int.Parse(Reverse(number1.ToString()));
            number2 = int.Parse(Reverse(number2.ToString()));

            int number3 = number1 + number2;
            string number3TosTring = Reverse(number3.ToString());
            
            ListNode l3 = null;

            for (int i = 0; i < number3TosTring.Length; i++)
            {
                ListNode newNode = new ListNode();

                newNode.val = int.Parse(number3TosTring[i].ToString());
                newNode.next = null;

                if (l3 == null)
                {
                    l3 = newNode;
                }
                else
                {
                    ListNode temp = new ListNode();
                    temp = l3;

                    while (temp.next!= null)
                        temp = temp.next;

                    temp.next= newNode;
                }
            }

            return l3;
        }
        private static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        public static List<int> AddTwoNumbers(List<int> l1, List<int> l2)
        { 
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (int i in l1)
                sb1.Append(i.ToString());

            foreach (int i in l2)
                sb2.Append(i.ToString());

            int.TryParse(sb1.ToString(), out int number1);
            int.TryParse(sb2.ToString(), out int number2);

            int number3 = number1+ number2;
            string number3TosTring = number3.ToString();

            List<int> l3 = new List<int>(); 
            for (int i = 0; i < number3TosTring.Length; i++)
            {
                l3.Add(int.Parse(number3TosTring[i].ToString()));
            }

            return new List<int>();
        }
    }
}
