using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ExtractPricesLINQ
{
    class ExtractPricesLINQ
    {
        static void Main()
        {
            var uri = "../../../catalogue.xml"; //edit the URI if you have problems

            var doc = XDocument.Load(uri);

            IEnumerable<string> albumsCollection = from album in doc.Descendants("album")
                                                   where int.Parse(album.Element("year").Value) < 2011
                                                   select album.Element("price").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumsCollection));
        }
    }
}
