using System;
using System.Collections.Generic;

namespace Twitch.Net.Model
{
    public class TwitchList<T>
    {
        public Dictionary<string,object> Links  { get; set; }
        public int Total { get; set; }
        public IEnumerable<T> List { get; set; } 
    }
}
