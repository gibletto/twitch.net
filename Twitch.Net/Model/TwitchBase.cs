using System.ComponentModel;


namespace Twitch.Net.Model
{
    public abstract class TwitchBase
    {
        [DisplayName("error")]
        public string Error { get; set; }
        [DisplayName("message")]
        public string Message { get; set; }
    }
}
