namespace UniversityRegistration.Models
{
    public class Student : BaseEntity
    {
        public int? DepartmentId { get; set; }

        public virtual Department DeptName { get; set; }


        public int? FacultyId { get; set; }
        public virtual Faculty FacultyName { get; set; }
       
    }
}
