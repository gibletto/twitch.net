using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class ChatLinks
    {
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
    }
}
