using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
	class Program
	{
		static void Main(string[] args)
		{
			var number1 = 11;
			var number2 = 10;
			if (number1 == 10)
			{
				Console.WriteLine("Number1 is 10");
			}
			else if (number1 == 20)
			{
				Console.WriteLine("Number1 is 20");
			}
			else
			{
				Console.Write("Number1 is not 10 or 20");
			}

			//Single Line If
			Console.WriteLine(number2 == 10 ? "Number2 is 10" : "Number2 is not 10");

			//switch-start
			switch (number1)
			{
				case 10:
					Console.WriteLine("Number1 is 10");
					break;
				case 20:
					Console.WriteLine("Number1 is 20");
					break;
				default:
					Console.Write("Number1 is not 10 or 20");
					break;
			}//sw

			//coklu-if
			if (number1 >= 0 && number1 <= 100)
			{
				Console.WriteLine("Number1 is between 0-100");
			}
			else if (number1 > 100 && number1 <= 200)
			{
				Console.WriteLine("Number1 is between 101-200");
			}
			else if (number1 > 200 || number1 < 0)
			{
				Console.WriteLine("Number1 is less than 0 or greater than 200");
			}

			//ic ice if
			if (number1 < 100)
			{
				if (number1 >= 90 && number1 < 95)
				{

				}
				else
				{

				}
			}

			Console.ReadLine();
		}
	}
}
