using System.Collections.Generic;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    [JsonObject("emoticons")]
    public class Emoticon
    {
        [JsonProperty("regex")]
        public string Regex { get; set; }
        [JsonProperty("images")]
        public IEnumerable<Image> Images { get; set; }
    }
}
