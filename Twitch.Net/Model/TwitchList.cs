using System.Collections.Generic;
using Newtonsoft.Json;
using Twitch.Net.Helpers;

namespace Twitch.Net.Model
{
    [JsonObject(ItemConverterType = typeof(TwitchListConverter))]
    public class TwitchList<T> : TwitchListBase
    {
        public IEnumerable<T> List { get; set; } 
    }
}
