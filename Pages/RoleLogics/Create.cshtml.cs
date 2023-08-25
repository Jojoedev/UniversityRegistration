using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniversityRegistration.Pages.RoleLogics
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private RoleManager<IdentityRole> _roleManager;
        public CreateModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public IdentityRole identityRole { get; set; } 
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost(IdentityRole identityRole)
        {
           // string roleName = identityRole.Name;
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(identityRole);

                
               return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
