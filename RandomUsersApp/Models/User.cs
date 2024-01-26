using System.Text.Json.Serialization;

namespace RandomUsersApp.Models
{
    public class User
    {
        public int id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
    }
}
