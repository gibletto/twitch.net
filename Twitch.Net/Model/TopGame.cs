using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("top")]
    public class TopGame
    {
        [JsonProperty("game")]
        public Game Game { get; set; }
        [JsonProperty("viewers")]
        public long Viewers { get; set; }
        [JsonProperty("channels")]
        public long Channels { get; set; }
    }
}
