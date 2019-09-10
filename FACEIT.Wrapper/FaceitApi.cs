using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FACEIT.Wrapper.Players;
using Newtonsoft.Json;

namespace FACEIT.Wrapper
{
    public class FaceitApi
    {
        // Base
        internal const string BaseUrl = "https://open.faceit.com/data";

        // Versions
        internal const string VersionOne = "v1";
        internal const string VersionTwo = "v2";
        internal const string VersionThree = "v3";
        internal const string VersionFour = "v4";

        // Interfaces

        // Methods
        internal const string Player = "players";

        // Parameters
        internal const string Nickname = "?nickname=";

        private string ApiKey { get; set; }

        /// <summary>
        /// Initialize the FACEIT API class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FaceitApi(string apiKey)
        {
            this.ApiKey = apiKey;
        }
        
        internal static async Task<string> GetAsync(string apiKey, string version, string method, string parameters = "")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                var message = await client.GetAsync($"{BaseUrl}/{version}/{method}/{parameters}");
                if (message.StatusCode == HttpStatusCode.OK)
                {
                    return await message.Content.ReadAsStringAsync();
                }

                throw new FaceitApiException(await message.Content.ReadAsStringAsync());
            }
        }

        #region Championships

        #endregion

        #region Games

        #endregion

        #region Hubs

        #endregion

        #region Leaderboards

        #endregion

        #region Matches

        #endregion

        #region Organizers

        #endregion

        #region Players

        public async Task<Player> GetPlayerByNickname(string nickname)
        {
            var parameters = $"{nickname}";
            var request = await GetAsync(this.ApiKey, VersionFour, Player, parameters);
            return JsonConvert.DeserializeObject<Player>(request);
        }

        public async Task<Player> GetPlayerById(string id)
        {
            var request = await GetAsync(this.ApiKey, VersionFour, Player, id);
            return JsonConvert.DeserializeObject<Player>(request);
        }

        #endregion

        #region Rankings

        #endregion

        #region Search

        #endregion

        #region Teams

        #endregion

        #region Tournaments

        #endregion


        private class FaceitApiException : Exception
        {
            public FaceitApiException(string message)
                : base(message)
            {
            }
        }
    }
}
