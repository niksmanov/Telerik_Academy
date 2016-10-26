using System;
using System.Data.OleDb;

namespace ReadFromExcel
{
    //6. Write a program that reads your MS Excel file 
    //through the OLE DB data provider and displays the name and score row by row:
    class StartUp
    {
        static void Main()
        {
            var connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   @"Data Source= ..\..\people.xlsx;" +
                                   @"Extended Properties='Excel 12.0 Xml;" +
                                   @"HDR=YES;'";


            //IF THE CODE BELOW DOESNT WORK
            //ERROR:'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine
            //INSTALL => https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734
            //IF YOU DON'T WANT TO INSTALL IT SEE THE IMAGE IN THE PROJECT FOLDER

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                var command = new OleDbCommand("select * from [People$]", connection);
                command.Connection = connection;

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader["Name"];
                        var score = reader["Score"];
                        Console.WriteLine("Name: {0} === Score: {1}", name, score);
                    }
                }

            }
        }
    }
}
