using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PortfolioAPI.Models
{
    [Table("Examples")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Name))]
    public class Example
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("subDescription")]
        public string? SubDescription { get; set; }

        public Example() {}
    }
}
