using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace JSONProcessingInNET
{
    class JSONProcessingInNET
    {
        static void Main()
        {
            var uri = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            var directory = "../../downloaded.xml";

            //Download the content of the feed programatically
            var downloader = new WebClient();
            downloader.DownloadFile(uri, directory);


            //Parse the XML from the feed to JSON
            var doc = XDocument.Load(uri);
            string jsonText = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            //Console.WriteLine(jsonText); //test output


            //Select all video titles and print them on the console
            var jsonObj = JObject.Parse(jsonText);

            var children = jsonObj["feed"]["entry"];

            foreach (var child in children)
            {
                Console.WriteLine(child["title"]);
            }


            //Parse the videos from JSON to POCO
            var videosCollecion = new List<Video>();

            foreach (var video in children)
            {
                var videoElement = JsonConvert.DeserializeObject<Video>(video.ToString());

                videosCollecion.Add(videoElement);
            }
            //Console.WriteLine(string.Join(Environment.NewLine, videosCollecion)); //test output


            //Using the POCOs create a HTML page that shows all videos from the RSS
            var htmlDirectory = "../../outputHtml.html";

            using (var writer = new StreamWriter(htmlDirectory))
            {
                writer.Write("<html><head><title>Telerik Lectures</title></head><body>");

                foreach (Video video in videosCollecion)
                {
                    string url = video.Link.ToString().Replace("watch?v=", "embed/");

                    writer.Write("<div style=\"width:520px;height:320px;float:left;display:inline-block;\"><iframe width=\"500\" height=\"300\" src=\"{0}\"></iframe></div>", url);
                }

                writer.Write("</body></html>");
            }
        }
    }
}
