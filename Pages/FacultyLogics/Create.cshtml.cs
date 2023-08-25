using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.FacultyLogics
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public CreateModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public Faculty faculty { get; set; }
        public ActionResult OnGet()
        {
            return Page();

        }

        public ActionResult OnPost(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _Context.Faculties.Add(faculty);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return Page();
        }
    }
}
