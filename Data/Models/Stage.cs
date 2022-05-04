using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationaldatabase.Data.Models
{
    public class Stage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime? DateToComplete { get; set; }

        public ICollection<Module> Modules { get; set; } = new List<Module>();

        public ICollection<Contractor> Contractors { get; set; } = new List<Contractor>();
    }
}
