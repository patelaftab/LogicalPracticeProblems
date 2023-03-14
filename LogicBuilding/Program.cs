using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programing");
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("\nChoose a Option To get Output Of desired Program\n" + "" +
                    "Choose 1: Check Odd Even Number Program\n" + "" +
                    "Choose 2: Check Odd Numbers In Given Range\n"+
                    "Choose 3: Check Giiven Number IS positive Or Not\n"+
                    "Choose 4: Check Largest Among Two Numbers\n" +
                    "Choose 5: Check Swap Numbers Program\n"+
                    "Choose 6: To Stop running Program\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        OddEven.EvenOddNumbers();
                        break;
                    case 2:
                        OddNumbers.ChekingOddNumbers();
                        break;
                    case 3:
                        PositiveNumbers.PositiveOrNot();
                        break;
                    case 4:
                        LargestOfTwo.LargestNumber();
                        break;
                    case 5:
                        SwapNumbersProgram.SwapNumbers();
                        break;
                    case 6:
                        flag = true;
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
