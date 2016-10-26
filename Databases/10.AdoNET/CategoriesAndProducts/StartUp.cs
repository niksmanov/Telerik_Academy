using System;
using System.Data.SqlClient;

namespace CategoriesAndProducts
{
    class StartUp
    {
        //3. Write a program that retrieves from the Northwind database all product categories 
        //and the names of the products in each category:
        static void Main()
        {
            var connection = new SqlConnection
            ("Server=NIKO-PC\\SQLSERVER;Database=Northwind;Integrated Security=true");
            //Choose your server name!
            connection.Open();

            using (connection)
            {
                var command = new SqlCommand
                ("SELECT c.CategoryName, p.ProductName FROM Categories c, Products p WHERE c.CategoryID = p.CategoryID",
                     connection);

                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine($"{categoryName}: {productName}");
                    }
                }

                connection.Close();
            }

        }
    }
}
