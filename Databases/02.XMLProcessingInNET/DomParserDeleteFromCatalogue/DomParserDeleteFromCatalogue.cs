using System.Xml;

namespace DomParserDeleteFromCatalogue
{
    class DomParserDeleteFromCatalogue
    {
        static void Main()
        {
            var uri = "../../../catalogue.xml"; //edit the URI if you have problems
            var deletedAlbumsUri = "../../deletedCatalogue.xml";

            var doc = new XmlDocument();
            doc.Load(uri);

            var albumsCollection = doc.DocumentElement;

            foreach (XmlNode album in albumsCollection)
            {
                if (int.Parse(album["price"].InnerText) > 20)
                {
                    albumsCollection.RemoveChild(album);
                }
            }

            doc.Save(deletedAlbumsUri);
        }
    }
}
