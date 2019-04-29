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

            try
            {
                int poz = number28ImplementstrStr.StrStr("babba", "bbb");
                Console.WriteLine("visszatert ertek: "+poz.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
