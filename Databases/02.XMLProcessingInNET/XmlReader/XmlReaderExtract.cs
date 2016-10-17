using System;
using System.Xml;

namespace XmlReaderExtract
{
    class XmlReaderExtract
    {
        static void Main()
        {
            var uri = "../../../catalogue.xml"; //edit the URI if you have problems

            using (var reader = XmlReader.Create(uri))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementContentAsString());
                    }
                }
            }
        }
    }
}
