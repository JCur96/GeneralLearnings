using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    public class LargerNumber
    {
        public void DisplayLargerNum()
        {
            Console.WriteLine("Please enter a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine("Number {0} is larger", number1);
            }
            else
            {
                Console.WriteLine("Number {0} is larger", number2);
            }

        }
    }
}
