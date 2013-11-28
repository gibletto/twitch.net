using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    [DisplayName("streams")]
    public class Stream
    {
        [DisplayName("_id")]
        public long Id { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
        [DisplayName("broadcaster")]
        public string Broadcaster { get; set; }
        [DisplayName("preview")]
        public Dictionary<string, object> Preview { get; set; }
        [DisplayName("viewers")]
        public long Viewers { get; set; }
        [DisplayName("channel")]
        public Channel Channel { get; set; }
        [DisplayName("name")]
        public string Name { get; set; }
        [DisplayName("game")]
        public string Game { get; set; }
    }
}
