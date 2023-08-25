using System.ComponentModel.DataAnnotations;

namespace UniversityRegistration.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        [Display(Name ="Faculty Name")]
        [Required]
        public string Name { get; set; }
    }
}
