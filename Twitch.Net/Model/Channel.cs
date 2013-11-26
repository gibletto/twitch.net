using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class Channel
    {
        [DisplayName("_id")]
        public long Id { get; set; }
        [DisplayName("name")]
        public string Name { get; set; }
        [DisplayName("game")]
        public string Game { get; set; }
        [DisplayName("created_at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [DisplayName("title")]
        public string Title { get; set; }
        [DisplayName("banner")]
        public string Banner { get; set; }
        [DisplayName("video_banner")]
        public string VideoBanner { get; set; }
        [DisplayName("background")]
        public string Background { get; set; }
        [DisplayName("logo")]
        public string Logo { get; set; }
        [DisplayName("mature")]
        public bool Mature { get; set; }
        [DisplayName("url")]
        public string Url { get; set; }
        [DisplayName("display_name")]
        public string DisplayName { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; } 
        [DisplayName("teams")]
        public List<Team> Teams { get; set; }       
    }
}
