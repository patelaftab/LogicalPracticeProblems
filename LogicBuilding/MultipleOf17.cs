using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    public class MultipleOf17
    {
        public static void PrintingMultipleof17()
        {
            int i,number = 100;
            for(i=1;i<=number;i++)
            {
                if (i % 17 == 0)
                {
                    Console.Write("The Multiple Of 17 is: {0}\n",i);
                    
                }
            }
        }
    }
}
