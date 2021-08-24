using Newtonsoft.Json;

namespace Staging_project.Tests.API_testing
{
    internal class LoginToken
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}