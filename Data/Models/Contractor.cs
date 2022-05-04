using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationaldatabase.Data.Models
{
    public class Contractor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        public ICollection<Module> Modules { get; set; } = new List<Module>();

        //public int StageId { get; set; }

        //[ForeignKey(nameof(StageId))]
        //public Stage Stage { get; set; }

        public ICollection<Stage> Stages { get; set; } = new List<Stage>();
    }
}
