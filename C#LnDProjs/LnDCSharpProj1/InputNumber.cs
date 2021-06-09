using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnDCSharpProj1
{
	public class InputNumber
	{
		public void GiveNumber()
		{
			int number;
			Console.WriteLine("Please enter a number between 1 and 10");

			var input = Console.ReadLine();
			number = int.Parse(input);

			if (number >= 1 && number <= 10)
            {
				Console.WriteLine("Valid");
            }
			else
            {
				Console.WriteLine("Invalid");
            }
		}
	}

}
