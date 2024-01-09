using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] students = new string[3];
			students[0] = "student1";
			students[1] = "student2";
			students[2] = "student3";

			string[] students2 = new[] { "student1", "student2", "student3" };

			string[] students3 = new string[3]{"student1" , "student2", "student3" };

			foreach (var item in students)
			{
				Console.WriteLine(item);
			}

			string[,] regions = new string[5, 3]
			{
				{ "İstanbul","İzmit","Balıkesir" },
				{ "Ankara","Konya","Kırıkkale" },
				{ "Antalya","Adana","Mersin" },
				{ "Rize","Trabzon","Samsun" },
				{ "İzmir","Muğla","Manisa" },
			};

			for (int i = 0; i <= regions.GetUpperBound(0); i++)
			{
				for (int j = 0; j <= regions.GetUpperBound(1); j++)
				{
					Console.WriteLine(regions[i,j]);
				}
					Console.WriteLine("******");
			}

			Console.ReadLine();
		}
	}
}
