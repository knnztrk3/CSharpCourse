using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] persons = new Person[3] {
			 new Customer
			 { 
				 FirstName = "Ahmet"
			 },
			 new Student
			 { 
				 FirstName = "Mehmet" 
			 },
			 new Person
			 {
				 FirstName = "Ayse"
			 }};

			foreach (var person in persons)
			{
				Console.WriteLine(person.FirstName);
			}
			//Customer customer = new Customer();
			//customer.FirstName = "Ahmet";
			//customer.Id = 1;
			//customer.LastName = "Tur";
			//customer.City = "city";

			Console.ReadLine();
		}
	}

	class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	interface IPerson
	{

	}
	interface IPerson2
	{

	}

	class Customer : Person,IPerson,IPerson2
	{
		public string City { get; set; }
	}

	class Student : Person
	{
		public string SchoolName { get; set; }
	}
}
