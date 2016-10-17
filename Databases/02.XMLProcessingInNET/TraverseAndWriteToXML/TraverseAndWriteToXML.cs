using System.IO;
using System.Xml;

namespace TraverseAndWriteToXML
{
    class TraverseAndWriteToXML
    {
        static void Main()
        {
            var path = "../../";
            var output = "../../output.xml";
            var dirFinder = new DirectoryInfo(path);
            var fullPath = dirFinder.FullName;

            using (var writer = XmlWriter.Create(output, new XmlWriterSettings()))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("directories");
                Traverse(writer, fullPath);

                writer.WriteEndDocument();
            }
        }

        public static void Traverse(XmlWriter writer, string fullPath)
        {

            foreach (var dir in Directory.GetDirectories(fullPath))
            {
                writer.WriteStartElement("directory");
                writer.WriteElementString("name", dir);
                Traverse(writer, dir);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(fullPath))
            {
                writer.WriteStartElement("file");
                writer.WriteElementString("name", file);
                writer.WriteEndElement();
            }
        }
    }
}
