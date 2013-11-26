using System.ComponentModel;

namespace Twitch.Net.Model
{
    public class Image
    {
        [DisplayName("emoticon_set")]
        public long EmoticonSet { get; set; }
        [DisplayName("height")]
        public long Height { get; set; }
        [DisplayName("width")]
        public long Width { get; set; }
        [DisplayName("url")]
        public string Url { get; set; }
    }
}
