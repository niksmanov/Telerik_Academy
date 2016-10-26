using System;
using System.Data.SqlClient;

namespace NameAndDescription
{
    class StartUp
    {
        //2. Write a program that retrieves the name and description of all categories in the Northwind DB:
        static void Main()
        {
            var connection = new SqlConnection
            ("Server=NIKO-PC\\SQLSERVER;Database=Northwind;Integrated Security=true");
            //Choose your server name!
            connection.Open();
                        
            using (connection)
            {
                var command = new SqlCommand("SELECT CategoryName, Description FROM Categories", connection);

                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine($"{categoryName}: {description}");
                    }
                }

                connection.Close();
            }
        }
    }
}
