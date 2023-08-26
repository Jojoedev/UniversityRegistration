using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniversityRegistration.Pages.RoleLogics
{
    [Authorize(Roles ="IT")]
    public class CreateModel : PageModel
    {
        private RoleManager<IdentityRole> _roleManager;
        public CreateModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public IdentityRole Role { get; set; } 
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost(IdentityRole Role)
        {
           // string roleName = identityRole.Name;
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(Role);
               return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
