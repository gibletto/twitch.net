using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class Block
    {
        [JsonProperty("_id")]
        public long Id { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("user")]
        public User User{ get; set; }
        [DisplayName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
