using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XPath
{
    class XPath
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalogue.xml"); //edit the URI if you have problems
            string xPathQuery = "/albums/album/artist";

            var elementsList = new List<string>();

            var albumsCollection = doc.SelectNodes(xPathQuery);

            foreach (XmlNode album in albumsCollection)
            {
                elementsList.Add(album.InnerText);
            }

            var list = from a in elementsList
                       group a by a into g
                       let count = g.Count()
                       orderby count descending
                       select new { Value = g.Key, Count = count };

            foreach (var item in list)
            {
                Console.WriteLine("Author: " + item.Value + " Albums: " + item.Count);
            }
        }
    }
}
