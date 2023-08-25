using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.FacultyLogics
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
        public List<Faculty> faculty { get; set; }
        public void OnGet()
        {
            faculty = _Context.Faculties.ToList();
        }
    }
}
