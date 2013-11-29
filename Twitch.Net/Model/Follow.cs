using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("follows")]
    public class Follow : TwitchBase
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}
