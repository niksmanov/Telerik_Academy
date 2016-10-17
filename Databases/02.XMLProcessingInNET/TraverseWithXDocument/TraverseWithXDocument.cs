using System.IO;
using System.Xml.Linq;

namespace TraverseWithXDocument
{
    class TraverseWithXDocument
    {
        static void Main()
        {
            var path = "../../";
            var output = "../../output.xml";
            var dirFinder = new DirectoryInfo(path);
            var fullPath = dirFinder.FullName;


            var writer = new XElement("main", fullPath);

            writer.Add(Traverse(fullPath));
            writer.Save(output);
        }

        public static XElement Traverse(string fullPath)
        {
            var directory = new XElement("directory", fullPath);

            foreach (var dir in Directory.GetDirectories(fullPath))
            {
                directory.Add(Traverse(dir));
            }

            foreach (var file in Directory.GetFiles(fullPath))
            {
                var fileLocate = new XElement("file", file);

                directory.Add(fileLocate);
            }

            return directory;
        }
    }
}

