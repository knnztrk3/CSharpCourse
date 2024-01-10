using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			//Intro();

			string sentence = "Hello World!";

			int result = sentence.Length;
			var result2 = sentence.Clone();

			sentence = "Helloo World.";

			bool result3 = sentence.EndsWith("!"); // Output: False
			bool result4 = sentence.StartsWith("Hello"); //Output: True

			var result5 = sentence.IndexOf("W"); //Output: 7
			var result6 = sentence.IndexOf(" "); //Output: 6
			var result7 = sentence.LastIndexOf(" "); //Output: 6

			var result8 = sentence.Insert(0, "Strings, "); //Output: Strings, Helloo World.
			var result9 = sentence.Substring(7,5); //Output: World
			var result10 = sentence.ToUpper(); //Output: HELLOO WORLD.
			var result11 = sentence.ToLower(); //Output: helloo world.
			var result12 = sentence.Replace(" ", "-"); //Output: Helloo-World.
			var result13 = sentence.Remove(6, 7); //Output: Helloo

			Console.WriteLine(result2);
			Console.WriteLine(result8);

			Console.ReadLine();
		}

		private static void Intro()
		{
			string city = "Ankara";

			Console.WriteLine(city[0]); //Output: A

			foreach (var item in city)
			{
				Console.WriteLine(item);
			}

			string city2 = "Istanbul";
			//string result = city + city2;
			Console.WriteLine(string.Format("{0} {1}", city, city2));
		}
	}
}
