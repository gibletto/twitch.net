using System;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class Authorization
    {
        [DisplayName("created_at")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [DisplayName("scopes")]
        public string[] Scopes { get; set; }
    }
}
