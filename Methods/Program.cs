using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Add();
			Add();
			Add();
			Add();
			var result = Add1(15, 56);
			var result2 = Add2(56);

			int number1;
			int number2 = 100;
			var result3 = Add3(out number1, number2); //ref

			Console.WriteLine(result);
			Console.WriteLine(result2);
			Console.WriteLine(result3);
			Console.WriteLine(number1);
			Console.WriteLine(Multiply(2, 4));
			Console.WriteLine(Multiply(2, 4, 5));
			Console.WriteLine(Add4(55, 25, 22, 55, 77));
			Console.ReadLine();
		}

		static void Add()
		{
			Console.WriteLine("Added!!!");
		}

		static int Add1(int number1, int number2)
		{
			var result = number1 + number2;
			return result;
		}

		//default parametre
		//default degerler her zaman parametrelerin en sonunda olması gerekiyor
		static int Add2(int x, int number1 = 10, int number2 = 30)
		{
			var result = number1 + number2 + x;
			return result;
		}

		static int Add3(out int number1, int number2) //ref
		{
			number1 = 30;
			return number1 + number2;
		}

		static int Multiply(int number1, int number2)
		{
			return number1 * number2;
		}

		static int Multiply(int number1, int number2, int number3)
		{
			return number1 * number2 * number3;
		}

		static int Add4(int number, params int[] numbers) 
		{
			return numbers.Sum();
		}
	}
}
