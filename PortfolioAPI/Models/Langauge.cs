using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace PortfolioAPI.Models
{
    [Table("Languages")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Id))]
    public class Langauge
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("ExampleId")]
        public virtual Example? Example { get; set; }
        [ForeignKey("Example")]
        public int ExampleId { get; set; }
        public string? Type { get; set; }
    }
}
