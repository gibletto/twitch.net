using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class Featured
    {
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("stream")]
        public Stream Stream { get; set; }
    }
}
