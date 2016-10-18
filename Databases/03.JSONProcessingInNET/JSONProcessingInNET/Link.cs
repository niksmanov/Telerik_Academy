using Newtonsoft.Json;

namespace JSONProcessingInNET
{
    public class Link
    {
        [JsonProperty("@href")]
        public string LinkAddress { get; set; }

        public override string ToString()
        {
            return this.LinkAddress;
        }
    }
}
