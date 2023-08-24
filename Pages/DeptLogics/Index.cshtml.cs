using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.DeptLogics
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _Context;

        public IndexModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public List<Department> department { get; set; }
        public void OnGet()
        {
            department = _Context.Departments.ToList();
            
        }
    }
}
