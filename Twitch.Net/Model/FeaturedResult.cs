using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class FeaturedResult
    {
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("featured")]
        public IEnumerable<Featured> Featured { get; set; }
    }
}
