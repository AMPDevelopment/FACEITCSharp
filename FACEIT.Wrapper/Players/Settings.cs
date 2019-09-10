using Newtonsoft.Json;

namespace FACEIT.Wrapper.Players
{
    public class Settings
    {
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
    }
}
