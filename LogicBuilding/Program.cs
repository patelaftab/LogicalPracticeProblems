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
                Console.WriteLine("\nChoose a Option To get Output Of desired Program\n"+"" +
                    "Choose 1: Check Odd Even Number Program\n");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        OddEven.EvenOddNumbers();
                        break;
                    default:
                        Console.WriteLine("Choose a valid Options");
                        break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
