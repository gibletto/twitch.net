using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class Featured
    {
        [DisplayName("image")]
        public string Image { get; set; }
        [DisplayName("text")]
        public string Text { get; set; }
        [DisplayName("stream")]
        public Stream Stream { get; set; }
    }
}
