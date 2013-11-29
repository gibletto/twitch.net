using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class Authorization
    {
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("scopes")]
        public IEnumerable<string> Scopes { get; set; }
    }
}
