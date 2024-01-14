using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
	public class Product 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal UnitPrice { get; set; }
		public int StockAmount { get; set; }

		public Product()
		{

		}

		public Product(int ıd, string name, decimal unitPrice, int stockAmount)
		{
			Id = ıd;
			Name = name;
			UnitPrice = unitPrice;
			StockAmount = stockAmount;
		}
	}
}
