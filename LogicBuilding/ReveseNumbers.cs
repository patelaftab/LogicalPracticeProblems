using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class ReveseNumbers
    {
        public static void ReversingNumber()
        {
            Console.WriteLine("Enter Number To Be Reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder, reverse = 0;
            for (int i = 0; i <= number; i++)
            {
                reminder = number % 10;
                reverse = (reverse*10) + reminder;
                number=number / 10;
            }
            Console.WriteLine("Reversed Number is : {0}",reverse);
        }
    }
}
