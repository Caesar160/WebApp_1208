using Newtonsoft.Json;

namespace WebApp12_08.Models
{
    public class LoveUnit
    {
        [JsonProperty("fname")]
        public string Fname { get; set; }
        [JsonProperty("sname")]
        public string Sname { get; set; }
        [JsonProperty("percentage")]
        public int Percentage { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }

    }
}