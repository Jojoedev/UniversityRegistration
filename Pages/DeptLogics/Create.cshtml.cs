using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UniversityRegistration.Data;
using UniversityRegistration.Models;

namespace UniversityRegistration.Pages.DeptLogics
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
        public Department department { get; set; }
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(Department department)
        {
            if (ModelState.IsValid)
            {
                _Context.Departments.Add(department);
                _Context.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
