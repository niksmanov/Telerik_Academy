using Newtonsoft.Json;
using System.Text;

namespace JSONProcessingInNET
{
    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        public Link Link { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(this.Title);
            builder.Append(this.Link.ToString());

            return builder.ToString();
        }
    }
}
