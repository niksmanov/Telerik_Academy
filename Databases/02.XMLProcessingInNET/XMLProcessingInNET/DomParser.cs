using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace DomParser
{
    public class DomParser
    {
        public static void Main()
        {
            var uri = "../../../catalogue.xml"; //edit the URI if you have problems
            var doc = new XmlDocument();
            doc.Load(uri);

            var elementsList = new List<string>();

            var albumsCollection = doc.DocumentElement;

            foreach (XmlNode album in albumsCollection)
            {
                foreach (XmlNode item in album["artist"])
                {
                    elementsList.Add(item.InnerText);
                }
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
