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

			Customer customer = new Customer();
			customer.Id = 1;
			customer.FirstName = "Joe";
			customer.LastName = "Williams";
			customer.City = "New York";

			Customer customer2 = new Customer()
			{
				Id = 1,
				FirstName = "David",
				LastName = "Miller",
				City = "San Francisco"
			};

			Console.WriteLine(customer2.FirstName);

			Console.ReadLine();
		}
	}
}
