using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleriTypesAndVeriables
{
	class Program
	{
		static void Main(string[] args)
		{
			//Value Types
			//Console.WriteLine("Hello World!");
			
			double number5 = 10.4;
			decimal number6 = 10.4m;
			char character = 'K';
			bool condition = false;
			byte number4 = 0; // 0 ila 255
			short number3 = 32767;
			int number1 = 2147483647;
			long number2 = 9223372036854775807;
			var number7 = 10;
			number7 = 'A';

			//if("Friday" == )
			//if (Days.Friday == )

			Console.WriteLine("Number1 is {0}", number1);
			Console.WriteLine("Number2 is {0}", number2);
			Console.WriteLine("Number3 is {0}", number3);
			Console.WriteLine("Number4 is {0}", number4);
			Console.WriteLine("Number5 is {0}", number5);
			Console.WriteLine("Number6 is {0}", number6);
			Console.WriteLine("Number7 is {0}", number7);
			Console.WriteLine("Character is {0}", (int)character);
			Console.WriteLine(Days.Friday); // Output: Friday
			Console.WriteLine((int)Days.Friday); // Output: 4
			Console.ReadLine();
		}
	}

	enum Days
	{
		// Başlangıç değeri verebiliriz, 10,11,12,13,14,15,16
		//Monday = 10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
		Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
	}
}
