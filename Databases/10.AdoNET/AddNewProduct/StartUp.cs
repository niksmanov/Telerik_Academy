using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewProduct
{
    class StartUp
    {
        //4. Write a method that adds a new product in the Products table in the Northwind database:
        static void Main()
        {
            var connection = new SqlConnection
           ("Server=NIKO-PC\\SQLSERVER;Database=Northwind;Integrated Security=true");
            //Choose your server name!
            connection.Open();

            using (connection)
            {
                var cmd = new SqlCommand
                ("INSERT INTO Products(ProductName, UnitPrice, Discontinued) VALUES " +
                "(@name, @price, @disc)", connection);

                cmd.Parameters.AddWithValue("@name", "Beer");
                cmd.Parameters.AddWithValue("@price", 2);
                cmd.Parameters.AddWithValue("@disc", 1);

                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"Rows Affected: {rowsAffected}");
            }
            connection.Close();
        }
    }
}
