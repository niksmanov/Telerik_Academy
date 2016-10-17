using System;
using System.Collections.Generic;
using System.Xml;

namespace XmlReaderAndXmlWriter
{
    class XmlReaderAndXmlWriter
    {
        static void Main()
        {
            var input = "../../../catalogue.xml"; //edit the input if you have problems
            var output = "../../album.xml";

            var collection = new List<string>();

            using (var reader = XmlReader.Create(input))
            {
                while (reader.Read())
                {
                    if (reader.Name == "name" || reader.Name == "artist")
                    {
                        collection.Add(reader.ReadElementContentAsString());
                    }
                }
            }

            using (var writer = XmlWriter.Create(output, new XmlWriterSettings()))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("albums");

                int count = 0;
                foreach (var item in collection)
                {
                    var info = collection[count].Split(' ');
                    count++;

                    if (info[0] == "Album")
                    {
                        writer.WriteStartElement("album");
                    }
                    else
                    {
                        writer.WriteStartElement("artist");

                    }

                    writer.WriteElementString("name", info[0] + " " + info[1]);
                    writer.WriteEndElement();
                }
                writer.WriteEndDocument();
            }
        }
    }
}
