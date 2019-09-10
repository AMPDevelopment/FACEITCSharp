using Newtonsoft.Json;

namespace FACEIT.Wrapper.Players
{
    public class Infractions
    {
        [JsonProperty(PropertyName = "last_infraction_date")]
        public string LastInfractionDate { get; set; }

        [JsonProperty(PropertyName = "afk")]
        public int Afk { get; set; }

        [JsonProperty(PropertyName = "leaver")]
        public int Leaver { get; set; }

        [JsonProperty(PropertyName = "qm_not_checkedin")]
        public int QmNotCheckedin { get; set; }

        [JsonProperty(PropertyName = "qm_not_voted")]
        public int QmNotVoted { get; set; }
    }
}
