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
                    "Choose 2: Check Odd Numbers In Given Range\n" +
                    "Choose 3: Check Giiven Number IS positive Or Not\n" +
                    "Choose 4: Check Largest Among Two Numbers\n" +
                    "Choose 5: Check Swap Numbers Program\n" +
                    "Choose 6: Check a Number Which IS Devisible By Two\n" +
                    "Choose 7: Check Multiple Of 3 And 5\n" +
                    "Choose 8: Check Printing Of Multiple Of 17\n"+
                    "Choose 9: Check Sum Of Digits Of Numbers\n"+
                    "Choose 10: To Stop running Program\n");
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
                        NumberDivisibleByTwo.NumberCheck();
                        break;
                    case 7:
                        CheckingMultiple.MultipleOfThreeAndfive();
                        break;
                    case 8:
                        MultipleOf17.PrintingMultipleof17();
                        break;
                    case 9:
                        SumOfNumbers.SumOfDigitOfNumbers();
                        break;
                    case 10:
                        flag = true;
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
