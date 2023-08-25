using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniversityRegistration.Pages.RoleLogics
{
    public class CreateModel : PageModel
    {
        private RoleManager<IdentityUser> _roleManager;
        public CreateModel(RoleManager<IdentityUser> roleManager)
        {
            _roleManager = roleManager;
        }
        
        public RoleManager<IdentityUser> identityRole { get; set; }
        public ActionResult OnGet()
        {
            return Page();
        }

        public  async Task<IActionResult> OnPost(RoleManager<IdentityUser> roleManager)
        {
            if (ModelState.IsValid)
            {
                await _roleManager.CreateAsync(new IdentityUser());
                return RedirectToPage("/RoleLogics/Index");               

            }
            return Page();
        }
    }
}
