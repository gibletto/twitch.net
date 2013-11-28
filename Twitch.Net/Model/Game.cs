using System.Collections.Generic;
using System.ComponentModel;
namespace Twitch.Net.Model
{
    [DisplayName("games")]
    public class Game : TwitchBase
    {
        [DisplayName("_id")]
        public long Id { get; set; }
        [DisplayName("name")]
        public string Name { get; set; }
        [DisplayName("box")]
        public Dictionary<string, object> Box { get; set; }
        [DisplayName("logo")]
        public Dictionary<string, object> Logo { get; set; }
        [DisplayName("images")]
        public Dictionary<string, object> Images { get; set; }
        [DisplayName("_links")]
        public Dictionary<string, object> Links { get; set; }
        [DisplayName("giantbomb_id")]
        public long GiantBombId { get; set; }
        [DisplayName("popularity")]
        public long Popularity { get; set; }
    }
}
