using System.Text.Json.Serialization;

namespace PortfolioAPI.Models
{
    public class Contact
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        public Contact(string name = "", string email = "", string reason = "") 
        {
            Name = name;
            Email = email;
            Reason = reason;
        }
    }
}
