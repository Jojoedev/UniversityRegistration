using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.Logics
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public CreateModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public Student student { get; set; }
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(Student student)
        {
            if (ModelState.IsValid)
            {
                _Context.Students.Add(student);
                _Context.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
