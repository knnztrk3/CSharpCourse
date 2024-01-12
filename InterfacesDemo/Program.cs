using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IWorker[] workers = new IWorker[3]
			{
				new Manager(),
				new Worker(),
				new Robot()
			};

			foreach (var worker in workers)
			{
				worker.Work();
			}

			IEat[] eats = new IEat[2]
			{
				new Manager(),
				new Worker()
			};

			foreach (var eat in eats)
			{
				eat.Eat();
			}
			Console.ReadLine();
		}
	}

	interface IWorker
	{
		void Work();
	}

	interface IEat
	{
		void Eat();
	}

	interface ISalary
	{
		void GetSalary();
	}

	class Manager : IWorker, IEat, ISalary
	{
		public void Eat()
		{
			Console.WriteLine("Manager Eats");
		}

		public void GetSalary()
		{
			Console.WriteLine("Manager GetSalaries");
		}

		public void Work()
		{
			Console.WriteLine("Manager Works");
		}
	}

	class Worker : IWorker, ISalary, IEat
	{
		public void Eat()
		{
			Console.WriteLine("Worker Eats");
		}

		public void GetSalary()
		{
			Console.WriteLine("Worker GetSalaries");
		}

		public void Work()
		{
			Console.WriteLine("Worker Works");
		}
	}

	class Robot : IWorker
	{
		public void Work()
		{
			Console.WriteLine("Robot Works");
		}
	}
}
