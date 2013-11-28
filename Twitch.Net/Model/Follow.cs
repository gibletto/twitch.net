using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    [DisplayName("follows")]
    public class Follow : TwitchBase
    {
        [DisplayName("created_at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
        [DisplayName("channel")]
        public Channel Channel { get; set; }
    }
}
