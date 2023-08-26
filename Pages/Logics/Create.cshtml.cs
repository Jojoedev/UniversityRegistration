using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.Logics
{
    [Authorize(Roles = "IT")]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public CreateModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public Student student { get; set; }
        public SelectList faculties { get; set; }
        public SelectList departments { get; set; }

        
        public ActionResult OnGet()
        {
            faculties = new SelectList(_Context.Faculties.ToList(), "Id", "Name");
            departments = new SelectList(_Context.Departments.ToList(), "Id", "Name");
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
            return RedirectToPage("Index");
        }
    }
}
