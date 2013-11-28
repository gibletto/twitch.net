using System.ComponentModel;

namespace Twitch.Net.Model
{
    [DisplayName("ingests")]
    public class Ingest
    {
        [DisplayName("_id")]
        public long Id { get; set; }
        [DisplayName("name")]
        public string Name { get; set; }
        [DisplayName("default")]
        public bool Default { get; set; }
        [DisplayName("url_template")]
        public string UrlTemplate { get; set; }
        [DisplayName("availability")]
        public double Availability { get; set; }
    }
}
