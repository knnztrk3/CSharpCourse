﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
	public class ProductDal
	{
		SqlConnection _connection = new SqlConnection(@"server=yourservername; initial catalog=ETrade; integrated security=true;");
		public List<Product> GetAll()
		{
			ConnectionControl();

			SqlCommand command = new SqlCommand("Select * from Products", _connection);

			SqlDataReader reader = command.ExecuteReader();

			List<Product> products = new List<Product>();

			while (reader.Read())//veri okuyabildigi surece
			{
				Product product = new Product
				{
					Id = Convert.ToInt32(reader["Id"]),
					Name = reader["Name"].ToString(),
					StockAmount = Convert.ToInt32(reader["StockAmount"]),
					UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
				};
				products.Add(product);
			}

			reader.Close();
			_connection.Close();
			return products;
		}

		private void ConnectionControl()
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}
		}

		public void Add(Product product)
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("insert into Products values(@name, @unitPrice, @stockAmount)", _connection);
			command.Parameters.AddWithValue("@name", product.Name);
			command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

			command.ExecuteNonQuery();

			_connection.Close();
		}

		public void Update(Product product)
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("update Products set Name=@Name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
			command.Parameters.AddWithValue("@id", product.Id);
			command.Parameters.AddWithValue("@name", product.Name);
			command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

			command.ExecuteNonQuery();

			_connection.Close();
		}

		public void Delete(int id)
		{
			ConnectionControl();
			SqlCommand command = new SqlCommand("delete from Products where Id=@id", _connection);
			command.Parameters.AddWithValue("@id", id);

			command.ExecuteNonQuery();

			_connection.Close();
		}
	}
}
