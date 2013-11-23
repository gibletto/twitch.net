using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class TwitchList<T>
    {
        [DisplayName("_links")]
        public Dictionary<string,object> Links  { get; set; }
        [DisplayName("total")]
        public long Total { get; set; }
        [DisplayName("teams")]
        public T[] List { get; set; } 
    }
}
