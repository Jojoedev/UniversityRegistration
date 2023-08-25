using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.Logics
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _Context;

        public IndexModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public List<Student> students { get; set; }
        public void OnGet()
        {
            students = _Context.Students
                         .Include(x => x.Faculty)
                        .Include(n => n.Department)
                        .ToList();
                       
        }
    }
}
