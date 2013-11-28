using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class StreamSummary
    {
        [DisplayName("viewers")]
        public long Viewers { get; set; }

        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }

        [DisplayName("channels")]
        public long Channels { get; set; }
    }
}
