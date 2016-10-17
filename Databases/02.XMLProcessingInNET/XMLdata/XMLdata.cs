using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace XMLdata
{
    class XMLdata
    {
        static void Main()
        {
            var inputInformation = "../../information.txt";
            var outputInformation = "../../information.xml";  //edit the URI if you have problems

            var collection = new List<string>();

            using (var reader = new StreamReader(inputInformation))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    collection.Add(line);
                }
            }

            using (var writer = XmlWriter.Create(outputInformation, new XmlWriterSettings()))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("people");

                int count = 0;
                foreach (var item in collection)
                {
                    var person = collection[count].Split(' ');
                    count++;

                    writer.WriteStartElement("person");
                    writer.WriteElementString("name", person[0] + " " + person[1]);
                    writer.WriteElementString("address", person[2]);
                    writer.WriteElementString("phone", person[3]);
                    writer.WriteEndElement();
                }
                writer.WriteEndDocument();
            }
        }
    }
}
