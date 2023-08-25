using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UniversityRegistration.Pages.RoleLogics
{
    public class ListModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public ListModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        
        public  RoleManager<IdentityRole> role { get; set; }
        public void OnGet()
        {
           var roles = _roleManager.Roles.ToList();
        }
    }
}
