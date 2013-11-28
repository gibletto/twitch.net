using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    [DisplayName("teams")]
    public class Team : TwitchBase
    {
        [DisplayName("_id")]
        public long Id { get; set; }
        [DisplayName("created_at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [DisplayName("info")]
        public string Info { get; set; }
        [DisplayName("background")]
        public string Background { get; set; }
        [DisplayName("banner")]
        public string Banner { get; set; }
        [DisplayName("logo")]
        public string Logo { get; set; }
        [DisplayName("_links")]
        public Dictionary<string,object> Links { get; set; } 
        [DisplayName("name")]
        public string Name { get; set; }
        [DisplayName("display_name")]
        public string DisplayName { get; set; }
    }
}
