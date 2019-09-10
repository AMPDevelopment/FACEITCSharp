using System.Collections.Generic;
using Newtonsoft.Json;

namespace FACEIT.Wrapper.Players
{
    public class Player
    {
        [JsonProperty(PropertyName = "avatar")]
        public string Avatar { get; set; }

        // Todo: Unknown data type of property bans. https://developers.faceit.com/docs/tools/data_api
        [JsonProperty(PropertyName = "bans")]
        public IList<string> Bans { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "cover_featured_image")]
        public string CoverFeaturedImage { get; set; }

        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitUrl { get; set; }

        [JsonProperty(PropertyName = "friends_ids")]
        public IList<string> FriendsIds { get; set; }

        [JsonProperty(PropertyName = "games")]
        public IList<Game> Games { get; set; }

        [JsonProperty(PropertyName = "infractions")]
        public Infractions Infractions { get; set; }

        [JsonProperty(PropertyName = "membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty(PropertyName = "memberships")]
        public IList<string> Memberships { get; set; }

        [JsonProperty(PropertyName = "new_steam_id")]
        public string NewSteamId { get; set; }

        [JsonProperty(PropertyName = "nickname")]
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "platforms")]
        public Platforms Platforms { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerId { get; set; }

        [JsonProperty(PropertyName = "settings")]
        public Settings Settings { get; set; }

        [JsonProperty(PropertyName = "steam_id_64")]
        public string SteamId64 { get; set; }

        [JsonProperty(PropertyName = "steam_nickname")]
        public string SteamNickname { get; set; }
    }
}
