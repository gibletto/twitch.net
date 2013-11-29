using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class Channel : TwitchBase
    {
        [JsonProperty("_id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("game")]
        public string Game { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("banner")]
        public string Banner { get; set; }
        [JsonProperty("video_banner")]
        public string VideoBanner { get; set; }
        [JsonProperty("background")]
        public string Background { get; set; }
        [JsonProperty("logo")]
        public string Logo { get; set; }
        [JsonProperty("mature")]
        public bool Mature { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; } 
        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }       
    }
}
