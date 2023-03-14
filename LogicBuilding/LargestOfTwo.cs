using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class LargestOfTwo
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter a First Number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                Console.WriteLine("First Number Is Larger Number Than Second Number", firstnumber);
            }
            else { Console.WriteLine("Second Number Is Larger Than First Number", secondnumber); }
        }
    }
}
