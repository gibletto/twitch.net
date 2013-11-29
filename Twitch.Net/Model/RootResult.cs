using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class RootResult
    {
        [JsonProperty("token")]
        public Token Token { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; } 
    }
}
