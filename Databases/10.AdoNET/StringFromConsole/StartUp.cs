using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StringFromConsole
{
    class StartUp
    {
        static void Main()
        {
            var connection = new SqlConnection
            ("Server=NIKO-PC\\SQLSERVER;Database=Northwind;Integrated Security=true");
            //Choose your server name!

            Console.Write("Search for products: ");
            var searchString = Console.ReadLine();

            //For example write => Chef
            connection.Open();
            using (connection)
            {
                SqlCommand cmdCategories = new SqlCommand("SELECT ProductName FROM Products", connection);

                var products = new List<string>();
                SqlDataReader reader = cmdCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];
                        if (productName.Contains(searchString))
                        {
                            products.Add(productName);
                        }
                    }
                }

                Console.WriteLine(string.Format($@"Products containing '{searchString}'"));

                foreach (var product in products)
                {
                    Console.WriteLine($"- {product}");
                }
            }
            connection.Close();
        }
    }
}
