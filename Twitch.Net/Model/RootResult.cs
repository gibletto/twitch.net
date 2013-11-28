using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class RootResult
    {
        [DisplayName("token")]
        public Token Token { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; } 
    }
}
