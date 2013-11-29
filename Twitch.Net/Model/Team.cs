using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("teams")]
    public class Team : TwitchBase
    {
        [JsonProperty("_id")]
        public long Id { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("info")]
        public string Info { get; set; }
        [JsonProperty("background")]
        public string Background { get; set; }
        [JsonProperty("banner")]
        public string Banner { get; set; }
        [JsonProperty("logo")]
        public string Logo { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string,object> Links { get; set; } 
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
