using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    [DisplayName("videos")]
    public class Video : TwitchBase
    {
        [DisplayName("_id")]
        public string Id { get; set; }
        [DisplayName("title")]
        public string Title { get; set; }
        [DisplayName("recorded_at")]
        public DateTime RecordedAt { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; } 
        [DisplayName("embed")]
        public string Embed { get; set; }
        [DisplayName("url")]
        public string Url { get; set; }
        [DisplayName("views")]
        public long Views { get; set; }
        [DisplayName("preview")]
        public string Preview { get; set; }
        [DisplayName("length")]
        public long Length { get; set; }
        [DisplayName("game")]
        public string Game { get; set; }
        [DisplayName("description")]
        public string Description { get; set; }
    }
}
