using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationaldatabase.Data.Models
{
    public class Module
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public double SourceCodeVolume { get; set; }

        [Required]
        public double DocumentationVolume { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime? DateToComplete { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime? CompleteDate { get; set; }

        public int ContractorId { get; set; }

        [ForeignKey(nameof(ContractorId))]
        public Contractor Contractor { get; set; }

        public int StageId { get; set; }

        [ForeignKey(nameof(StageId))]
        public Stage Stage { get; set; }
    }
}
