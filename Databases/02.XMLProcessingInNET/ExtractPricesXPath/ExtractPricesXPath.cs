using System;
using System.Collections.Generic;
using System.Xml;

namespace ExtractPricesXPath
{
    class ExtractPricesXPath
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../../catalogue.xml"); //edit the URI if you have problems
            string xPathQuery = "/albums/album[year<2011]";

            var albumsCollection = doc.SelectNodes(xPathQuery);

            var elementsList = new List<string>();

            foreach (XmlNode album in albumsCollection)
            {
                elementsList.Add(album["name"].InnerText);
                elementsList.Add(album["price"].InnerText);
            }

            Console.WriteLine(string.Join(Environment.NewLine, elementsList));
        }
    }
}
