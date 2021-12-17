using Newtonsoft.Json;

namespace api_autenticacao_bearer.Models
{
    public class Usuario
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
 
    }
}