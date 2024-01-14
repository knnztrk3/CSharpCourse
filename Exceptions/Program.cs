using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			//ExceptionIntro();

			try
			{
				Find();
			}
			catch (RecordNotFoundException exception)
			{
				Console.WriteLine(exception.Message);
			}
			catch (Exception exception)
			{

			}

			//Method
			HandleException(() =>
			{
				Find();
			});

			Console.ReadLine();
		}

		private static void HandleException(Action action)
		{
			try
			{
				action.Invoke();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
		}

		private static void Find()
		{
			List<string> students = new List<string> { "David", "Joe", "Lin" };

			if (!students.Contains("Max"))
			{
				throw new RecordNotFoundException("Record not found.");
			}
			else
			{
				Console.WriteLine("Record Found!");
			}
		}

		private static void ExceptionIntro()
		{
			try
			{
				string[] students = new string[3] { "David", "Joe", "Lin" };
				students[3] = "Max";
			}
			catch (DivideByZeroException exception)
			{
				Console.WriteLine(exception.Message);
			}
			catch (IndexOutOfRangeException exception)
			{
				Console.WriteLine(exception.Message);
			}

			catch (Exception exception)//tum exception hatalari
			{
				//exception.InnerException->daha detayli exception
				Console.WriteLine(exception.Message);
			}
		}
	}
}
