using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class PalindromNumber
    {
        public static void PalindromeNumber()
        {
            Console.WriteLine("Enter Number To Check Palindrom ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int reminder, reverse = 0;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number = number / 10;
            }
            Console.WriteLine("Reversed Number is : {0}", reverse);
            if (reverse == temp)
                Console.WriteLine("Given Number is Palindrom Number");
            else
                Console.WriteLine("Given Nnumber Is Not a Plaindrom Number");
        }
    }
}
