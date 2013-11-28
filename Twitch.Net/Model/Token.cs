using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class Token
    {
        [DisplayName("authorization")]
        public Authorization Authorization { get; set; }
        [DisplayName("user_name")]
        public string UserName { get; set; }
        [DisplayName("valid")]
        public bool Valid { get; set; }
    }
}
