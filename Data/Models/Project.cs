using System.ComponentModel.DataAnnotations;

namespace Relationaldatabase.Data.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Module> Modules { get; set; } = new List<Module>();

        public ICollection<Contractor> Contractors { get; set; } = new List<Contractor>();

        public ICollection<Stage> Stages { get; set; } = new List<Stage>();
    }
}
