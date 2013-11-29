using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("games")]
    public class Game : TwitchBase
    {
        [JsonProperty("_id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("box")]
        public Dictionary<string, object> Box { get; set; }
        [JsonProperty("logo")]
        public Dictionary<string, object> Logo { get; set; }
        [JsonProperty("images")]
        public Dictionary<string, object> Images { get; set; }
        [JsonProperty("_links")]
        public Dictionary<string, object> Links { get; set; }
        [JsonProperty("giantbomb_id")]
        public long GiantBombId { get; set; }
        [JsonProperty("popularity")]
        public long Popularity { get; set; }
    }
}
