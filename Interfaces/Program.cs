using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			//InterfacesIntro();
			//Demo();

			ICustomerDal[] customerDals = new ICustomerDal[3]
			{
				new SqlServerCustomerDal(),
				new OracleCustomerDal(),
				new MySqlCustomerDal(),
			};

			foreach (var customerDal in customerDals)
			{
				customerDal.Add();
			}

			Console.ReadLine();
		}

		private static void Demo()
		{
			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(new SqlServerCustomerDal());
			customerManager.Add(new OracleCustomerDal()); // Veritabanımızı değiştirmek istediğimizde sadece implement etmemiz yeterli olucak 
		}

		private static void InterfacesIntro()
		{
			PersonManager manager = new PersonManager();
			Customer customer = new Customer
			{
				Id = 1,
				FirstName = "firstNamecustomer",
				LastName = "lastName",
				Address = "adres1",
				Age = 15
			};

			Student student = new Student
			{
				Id = 1,
				FirstName = "firstNamestudent",
				LastName = "lastName",
				Departmant = "department",
				Age = 15
			};

			Worker worker = new Worker
			{
				Id = 1,
				FirstName = "firstNameworker",
				LastName = "lastName",
				Departmant = "department",
				Age = 15
			};

			//manager.Add(new Customer
			//{
			//	Id = 1,
			//	FirstName = "firstName",
			//	LastName = "lastName",
			//	Address = "adres1",
			//	Age = 15
			//});

			manager.Add(student);
			manager.Add(customer);
			manager.Add(worker);


			//IPerson person = new IPerson(); // Soyut nesneler new'lenemez
			IPerson person = new Customer();
			person.FirstName = "TEST";
			IPerson person2 = new Student();
			IPerson person3 = new Worker();
		}
	}

	interface IPerson
	{
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		int Age { get; set; }
	}

	class Customer : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public string Address { get; set; }
	}

	class Student : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public string Departmant { get; set; }
	}

	class Worker : IPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public string Departmant { get; set; }
	}

	class PersonManager
	{
		//public void Add(Customer customer)
		//{
		//	Console.WriteLine(customer.FirstName);
		//}

		public void Add(IPerson person)
		{
			Console.WriteLine(person.FirstName);
		}
	}
}
