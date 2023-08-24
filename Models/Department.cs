using System.ComponentModel.DataAnnotations;

namespace UniversityRegistration.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Department Name")]
        public string? DeptName { get; set; }
    }
}
