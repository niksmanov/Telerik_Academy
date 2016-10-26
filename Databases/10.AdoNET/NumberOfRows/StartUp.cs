using System;
using System.Data.SqlClient;

namespace NumberOfRows
{
    public class StartUp
    {
        //1. Write a program that retrieves from the Northwind sample database 
        //in MS SQL Server the number of rows in the Categories table:       
        public static void Main()
        {
            var connection = new SqlConnection
            ("Server=NIKO-PC\\SQLSERVER;Database=Northwind;Integrated Security=true");
            //Choose your server name!
            connection.Open();
                        
            using (connection)
            {
                var command = new SqlCommand("SELECT COUNT(*) FROM Categories", connection);
                var rowsCount = (int)command.ExecuteScalar();
                Console.WriteLine($"The number of rows in the Categories table is: {rowsCount}");
            }

            connection.Close();
        }
    }
}
