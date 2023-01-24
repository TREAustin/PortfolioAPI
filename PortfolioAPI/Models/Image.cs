using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace PortfolioAPI.Models
{
    [Table("Images")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Id))]
    public class Image
    {
        [Key]
        [Required]
        public int? Id { get; set; }
        [ForeignKey("ExampleId")]
        public virtual Example? Example { get; set; }
        [ForeignKey("Example")]
        public int ExampleId { get; set; }
        public string? Url { get; set; }
    }
}
