namespace UniversityRegistration.Models
{
    public class Student : BaseEntity
    {
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }


        public int? FacultyId { get; set; }
        public virtual Faculty? Faculty { get; set; }
       
    }
}
