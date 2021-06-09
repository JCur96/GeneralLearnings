using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    public class PortraitOrLandscape
    {
        public void isPortrait()
        {
            Console.WriteLine("Please enter the Width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Height");
            int height = int.Parse(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("The image is Landscape");
            }
            else
            {
                Console.WriteLine("The image is Portrait");
            }
        }
    }
}
