using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class SpeedCamera
    {
        public void IsSpeeding()
        {
            Console.WriteLine("Please set speed limit, in MPH");
            var speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car, in MPH");
            var carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                var howMuchOver = carSpeed - speedLimit;
                var inFives = howMuchOver / 5;

                switch (inFives)
                {
                    case 1:
                        Console.WriteLine("1 demerit points");
                        break;
                    case 2:
                        Console.WriteLine("2 demerit points");
                        break;
                    case 3:
                        Console.WriteLine("3 demerit points");
                        break;
                    case 4:
                        Console.WriteLine("4 demerit points");
                        break;
                    case 5:
                        Console.WriteLine("5 demerit points");
                        break;
                    case 6:
                        Console.WriteLine("6 demerit points");
                        break;
                    case 7:
                        Console.WriteLine("7 demerit points");
                        break;
                    case 8:
                        Console.WriteLine("8 demerit points");
                        break;
                    case 9:
                        Console.WriteLine("9 demerit points");
                        break;
                    case 10:
                        Console.WriteLine("10 demerit points");
                        break;
                    case 11:
                        Console.WriteLine("1 1demerit points");
                        break;
                    case 12:
                        Console.WriteLine("12 demerit points");
                        Console.WriteLine("License Suspended");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
