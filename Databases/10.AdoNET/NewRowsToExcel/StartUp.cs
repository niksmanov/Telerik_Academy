using System;
using System.Data.OleDb;

namespace NewRowsToExcel
{
    //7. Implement appending new rows to the Excel file: 
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

                var command = new OleDbCommand(@"INSERT INTO [People$] Values(@name, @score)", connection);
                command.Parameters.AddWithValue("@name", "Ivan Ivanov");
                command.Parameters.AddWithValue("@score", 45);
                command.ExecuteNonQuery();

            }
        }
    }
}
