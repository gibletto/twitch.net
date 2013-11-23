using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class User
    {
        [DisplayName("name")]
        public string Name { get; set; }
        [DisplayName("display_name")]
        public string DisplayName { get; set; }
        [DisplayName("_id")]
        public long Id { get; set; }
        [DisplayName("created_at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
        [DisplayName("logo")]
        public string Logo { get; set; }

    }
}
