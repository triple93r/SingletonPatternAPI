using System.ComponentModel.DataAnnotations;

namespace SingletonPattern.Models
{
    public class PatientCreate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
