using System.ComponentModel;
using Newtonsoft.Json;

namespace Twitch.Net.Model
{
    public class Token
    {
        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
