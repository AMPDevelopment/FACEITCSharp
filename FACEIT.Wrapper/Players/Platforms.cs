using Newtonsoft.Json;

namespace FACEIT.Wrapper.Players
{
    public class Platforms
    {
        [JsonProperty(PropertyName = "steam")]
        public string Steam { get; set; }
    }
}
