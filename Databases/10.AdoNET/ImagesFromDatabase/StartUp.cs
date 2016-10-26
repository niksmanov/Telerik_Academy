using System;
using System.Data.SqlClient;
using System.IO;

namespace ImagesFromDatabase
{
    public class StartUp
    {
        //5. Write a program that retrieves the images for all categories 
        //in the Northwind database and stores them as JPG files in the file system.
        public static void Main()
        {
            var imagesPath = "../../images/";

            var connection = new SqlConnection
            ("Server=NIKO-PC\\SQLSERVER;Database=Northwind;Integrated Security=true");
            //Choose your server name!
            connection.Open();

            using (connection)
            {
                var cmd = new SqlCommand("SELECT CategoryName, Picture FROM Categories", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var categoryName = (string)reader["CategoryName"];
                        var escapedName = categoryName.Replace(@"/", @"-");
                        var picture = (byte[])reader["Picture"];
                        Console.WriteLine("Creating " + escapedName + ".jpg");

                        FileStream stream = File.OpenWrite(imagesPath + escapedName + ".jpg");
                        using (stream)
                        {
                            stream.Write(picture, 78, picture.Length - 78);
                        }
                    }
                }
            }
            connection.Close();
        }
    }
}

