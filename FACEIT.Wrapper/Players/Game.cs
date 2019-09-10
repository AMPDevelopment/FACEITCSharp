using System.Collections.Generic;

using Newtonsoft.Json;

namespace FACEIT.Wrapper.Players
{
    public class Game
    {
        [JsonProperty(PropertyName = "faceit_elo")]
        public int FaceitElo { get; set; }

        [JsonProperty(PropertyName = "game_player_id")]
        public string GamePlayerId { get; set; }

        [JsonProperty(PropertyName = "game_player_name")]
        public string GamePlayerName { get; set; }

        [JsonProperty(PropertyName = "game_profile_id")]
        public string GameProfileId { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "regions")]
        public IList<string> Regions { get; set; }

        [JsonProperty(PropertyName = "skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty(PropertyName = "skill_level_label")]
        public string SkillLevelLabel { get; set; }
    }
}
