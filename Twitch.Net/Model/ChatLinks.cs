using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class ChatLinks
    {
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
    }
}
