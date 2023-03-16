using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class SumOfNumbers
    {
        public static void SumOfDigitOfNumbers()
        {
            Console.WriteLine("Enter A Number");
            int number=Convert.ToInt32(Console.ReadLine());
            int modulus, sum = 0;
            while(number > 0)
            {
                modulus = number % 10;
                sum = modulus + sum;
                number = number / 10;
            }
            Console.WriteLine("Sum Is: {0}",sum);
        }
    }
}
