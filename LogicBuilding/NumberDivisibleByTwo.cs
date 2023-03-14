using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class NumberDivisibleByTwo
    {
        public static void NumberCheck()
        {
            Console.WriteLine("Enter a Number To Check Which Is Divisible By two Or Not");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number %2 == 0)
                Console.WriteLine("Number is Completely Divisible By Two");
            else { Console.WriteLine("Given Number IS not Divisible By Two"); }
        }
    }
}
