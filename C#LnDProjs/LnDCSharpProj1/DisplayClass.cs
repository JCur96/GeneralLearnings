using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class DisplayClass
    {
        public void DisplayLine(object inputText)
        {
            string stringtext = inputText.ToString();
            Console.WriteLine(stringtext);
        }

        public void DisplayToDo(object inputText)
        {
            string stringtext = inputText.ToString();
            var textWrapper = new TextWrap();
            Console.WriteLine(textWrapper.WrapText(stringtext));
        }
    }
}
