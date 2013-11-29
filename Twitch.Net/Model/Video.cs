using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("videos")]
    public class Video : TwitchBase
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("recorded_at")]
        public DateTime RecordedAt { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; } 
        [JsonProperty("embed")]
        public string Embed { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("views")]
        public long Views { get; set; }
        [JsonProperty("preview")]
        public string Preview { get; set; }
        [JsonProperty("length")]
        public long Length { get; set; }
        [JsonProperty("game")]
        public string Game { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
