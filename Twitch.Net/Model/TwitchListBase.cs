using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public abstract class TwitchListBase : TwitchBase
    {
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("_total")]
        public long Total { get; set; }
    }
}