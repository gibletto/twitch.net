using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("streams")]
    public class Stream
    {
        [JsonProperty("_id")]
        public long Id { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("broadcaster")]
        public string Broadcaster { get; set; }
        [JsonProperty("preview")]
        public Dictionary<string, object> Preview { get; set; }
        [JsonProperty("viewers")]
        public long Viewers { get; set; }
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("game")]
        public string Game { get; set; }
    }
}
