using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class StreamResult
    {
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
        [DisplayName("stream")]
        public Stream Stream { get; set; }
    }
}
