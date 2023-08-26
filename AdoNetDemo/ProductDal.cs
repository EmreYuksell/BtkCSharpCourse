using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Etrade; integrated security=true");
        public List< Product> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products",_connection );
            SqlDataReader reader = command.ExecuteReader();
           List< Product> products = new List< Product >();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnityPrice = Convert.ToDecimal(reader["UnityPrice"])
                };
                products.Add(product);
            }

            reader.Close( );
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
        public DataTable GetAll2()
        {
            
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();
            return dataTable;
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@UnityPrice,@StockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@UnityPrice", product.UnityPrice);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
