using System.ComponentModel;
namespace Twitch.Net.Model
{
    [DisplayName("top")]
    public class TopGame
    {
        [DisplayName("game")]
        public Game Game { get; set; }
        [DisplayName("viewers")]
        public long Viewers { get; set; }
        [DisplayName("channels")]
        public long Channels { get; set; }
    }
}
