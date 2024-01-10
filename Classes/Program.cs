using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();
			customerManager.Add();
			customerManager.Update();
			customerManager.Delete();

			ProductManager productManager = new ProductManager();
			productManager.Add();
			productManager.Update();
			productManager.Delete();

			Console.ReadLine();
		}
	}

	class CustomerManager
	{
		public void Add()
		{
			Console.WriteLine("Customer Added!");
		}

		public void Update()
		{
			Console.WriteLine("Customer Updated!");
		}

		public void Delete()
		{
			Console.WriteLine("Customer Deleted!");
		}
	}

	class ProductManager
	{
		public void Add()
		{
			Console.WriteLine("Product Added!");
		}

		public void Update()
		{
			Console.WriteLine("Product Updated!");
		}

		public void Delete()
		{
			Console.WriteLine("Product Deleted!");
		}
	}
}
