using System.Xml.Xsl;

namespace TransformXMLtoHTML
{
    class TransformXMLtoHTML
    {
        static void Main()
        {
            var xml = "../../../catalogue.xml";
            var xslt = "../../../catalogue.xslt";
            var outputHtml = "../../catalogue.html";

            var myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(xslt);
            myXslTrans.Transform(xml, outputHtml);
        }
    }
}
