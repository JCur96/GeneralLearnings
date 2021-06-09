using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class Remainder
    {
        public void isDivisibleBy3()
        {
            //set up an array of numbers 1 - 100
            var numbers = new int[100];
            var length = 100;
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1;
            }

            var count = 0;
            foreach (var number in numbers)
            {
                if (number % 3 == 0)
                {
                    count++;
                }
            }
            var dispaly = new DisplayClass();

            dispaly.DisplayLine(count);
        }
    }
}
