using System.Collections.Generic;
using System.ComponentModel;

namespace Twitch.Net.Model
{
    [DisplayName("emoticons")]
    public class Emoticon
    {
        [DisplayName("regex")]
        public string Regex { get; set; }
        [DisplayName("images")]
        public IEnumerable<Image> Images { get; set; }
    }
}
