using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class CheckingMultiple
    {
        public static void MultipleOfThreeAndfive()
        {
            Console.WriteLine("Enter A upper Range Of Numbers To Check Multiple Of 3 And 5");
            int number = Convert.ToInt32(Console.ReadLine());
            int i, a, b, sum = 0;
            for (i = 1; i <= number; i++)
            {
                a=i%3; b=i%3;
                if (a == 0 || b == 0)
                {
                    Console.Write("{0}\t", i);
                    sum =sum+ i;
                }
               
            }
            Console.WriteLine("Sum Of Numbers {0}:", sum);
        }
    }
}
