using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
    class RandomStringGenerator
    {
        public void GenerateRandomString()
        {
            const int length = 20;
            bool isValidPass;
            string fileName = @"C:\NonNetworkedArea\Sandbox\C#\randomStrings.txt";
            var random = new Random();
            var buffer = new char[length];
            string runAgain;
            do
            {
                isValidPass = false;

                while (isValidPass == false)
                {


                    for (var i = 0; i < length; i++)
                    {
                        buffer[i] = (char)(random.Next(33, 122));
                    }

                    //validate that at least one of each from the ranges below is in the buffer
                    var lowerCaseCounter = 0;
                    var upperCaseCounter = 0;
                    var specialCharCounter = 0;
                    var numberCounter = 0;
                    foreach (var number in buffer)
                    {
                        if (number >= 33 && number <= 47)
                        {
                            specialCharCounter = specialCharCounter + 1;
                        }
                        else if (number >= 48 && number <= 57)
                        {
                            numberCounter = numberCounter + 1;
                        }
                        else if (number >= 58 && number <= 64)
                        {
                            specialCharCounter = specialCharCounter + 1;
                        }
                        else if (number >= 65 && number <= 90)
                        {
                            upperCaseCounter = upperCaseCounter + 1;
                        }
                        else if (number >= 97 && number <= 122)
                        {
                            lowerCaseCounter = lowerCaseCounter + 1;
                        }
                    }

                    if (lowerCaseCounter == 0 || upperCaseCounter == 0 || specialCharCounter == 0 || numberCounter == 0)
                    {
                        isValidPass = false;

                    }
                    else
                    {
                        isValidPass = true;
                    }

                    //for (var i = 16; i < length; i++)
                    //{
                    //    buffer[i] = (char)(random.Next())) // special char ascii 33 - 47, 58 - 64, //65 - 90 for upper case 
                    // lower case is 97 - 122
                    // numbers are 48 - 57
                    //}
                }
                var password = new string(buffer);

                Console.WriteLine("Password is {0}. Copied password to clipboard.", password);
                Clipboard.SetText(password);
                Console.WriteLine("Appended Password to file {0}, for safekeeping. \nTherefore don't use these as actual passwords.", fileName);
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(password);
                }

                Console.WriteLine("Would you like to generate another Y/n?");
                runAgain = Console.ReadLine().ToLower();
                //runAgain = "y".Equals(input, StringComparison.OrdinalIgnoreCase);

            } while (runAgain.Equals("y", StringComparison.OrdinalIgnoreCase));
            {
                Application.Exit();
                //Console.ReadLine();
                //runAgain = "y".Equals(input, StringComparison.OrdinalIgnoreCase);
                //isValidPass = false;
            }
        }
    }
}