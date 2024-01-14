using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			//ArrayList();
			//List();



			Console.ReadLine();
		}

		private static void List()
		{
			List<string> cities = new List<string>() { "Ankara", "istanbul", "Bursa" };
			cities.Add("İzmir");
			//cities.Add(15);

			//Console.WriteLine(cities.Contains("Adana"));

			foreach (var city in cities)
			{
				Console.WriteLine(city);
			}

			//List<Customer> customers = new List<Customer>();
			//customers.Add(new Customer { id = 1, firstName = "David"});
			//customers.Add(new Customer { id = 2, firstName = "Joe"});

			List<Customer> customers = new List<Customer>
			{
				new Customer { id = 1, firstName = "David" },
				new Customer { id = 2, firstName = "Joe" },
			};

			var customer2 = new Customer { id = 3, firstName = "Hall" };
			customers.Add(customer2);
			customers.AddRange(new Customer[2]
			{
				new Customer{id = 4, firstName = "Ali"},
				new Customer{id = 5, firstName = "Ayse"}
			});

			Console.WriteLine(customers.Contains(customer2));

			//customers.Clear();

			var index = customers.IndexOf(customer2);
			Console.WriteLine("Customer2 indexi: {0} ", index);

			customers.Add(customer2);

			var indexCustomer2 = customers.LastIndexOf(customer2);
			Console.WriteLine("Customer2 sondan indexi: {0} ", indexCustomer2);

			customers.Insert(0, customer2); //0. indexe istedigimiz degeri ekle

			//customers.Remove(customer2); //birden fazla olsa bile Remove komutu buldugu ilk degeri silip islemi sonlandirir
			//customers.Remove(customer2);
			//customers.Remove(customer2);

			customers.RemoveAll(c => c.firstName == "Hall"); //buldugu tum sonuclari siler
															 //customers.RemoveAll(c => c.firstName == customer2.firstName);

			foreach (var customer in customers)
			{
				Console.WriteLine(customer.id + " " + customer.firstName);
			}

			var count = customers.Count;
			Console.WriteLine("Count : {0}", count);
		}

		private static void ArrayList()
		{
			ArrayList cities = new ArrayList();
			cities.Add("Ankara");
			cities.Add("Adana");

			cities.Add("İstanbul");
			cities.Add(19);
			cities.Add('A');

			foreach (var city in cities)
			{
				Console.WriteLine(city);
			}

			//Console.WriteLine(cities[2]);
		}
	}

	class Customer
	{
		public int id { get; set; }
		public string firstName { get; set; }

		public Customer()
		{

		}

		public Customer(int id, string firstName)
		{
			this.id = id;
			this.firstName = firstName;
		}
	}
}
