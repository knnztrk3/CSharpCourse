using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class Customer
	{
		//private int ID { get; set; }
		protected int ID { get; set; } 

		public void Save()
		{

			int id; //default private
			//ID
		}

		public void Delete()
		{
			//ID
		}
	}

	class Student 
	{
		public void Save()
		{
			
		}
	}
}
