using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XdocumentAndLINQ
{
    class XdocumentAndLINQ
    {
        static void Main()
        {
            var uri = "../../../catalogue.xml"; //edit the URI if you have problems

            var doc = XDocument.Load(uri);

            var songTitlesList = from album in doc.Descendants("album")
                                 from song in album.Descendants("song")
                                 select song.Element("title").Value;

            foreach (var item in songTitlesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
