using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class TwitchList<T>
    {
        [DisplayName("_links")]
        public Dictionary<string,object> Links  { get; set; }
        [DisplayName("_total")]
        public long Total { get; set; }
        public IEnumerable<T> List { get; set; } 
    }
}
