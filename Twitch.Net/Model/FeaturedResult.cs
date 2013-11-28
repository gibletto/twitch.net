using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class FeaturedResult
    {
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
        [DisplayName("featured")]
        public IEnumerable<Featured> Featured { get; set; }
    }
}
