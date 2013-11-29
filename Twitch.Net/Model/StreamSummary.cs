using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class StreamSummary
    {
        [JsonProperty("viewers")]
        public long Viewers { get; set; }

        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }

        [JsonProperty("channels")]
        public long Channels { get; set; }
    }
}
