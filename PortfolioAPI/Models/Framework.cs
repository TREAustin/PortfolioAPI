using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioAPI.Models
{
    [Table("Frameworks")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Id))]
    public class Framework
    {
        [Key]
        [Required]
        public int? Id { get; set; }

        [ForeignKey("ExampleId")]
        public virtual Example? Example { get; set; }
        [ForeignKey("Example")]
        public int ExampleId { get; set; }
        public string? Type { get; set; }
    }
}
