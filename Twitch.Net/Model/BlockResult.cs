using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class BlockResult
    {
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("blocks")]
        public IEnumerable<Block> Blocks { get; set; }
    }
}
