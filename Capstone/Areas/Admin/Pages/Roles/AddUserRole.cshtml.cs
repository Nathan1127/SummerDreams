using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Capstone.Areas.Admin.Pages.Roles
{
    public class AddUserRoleModel : PageModel
    {
        private RoleManager<IdentityRole> RoleManager { get; set; }
        private UserManager<IdentityUser> UserManager { get; set; }

        public AddUserRoleModel(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            RoleManager = roleManager;
            UserManager = userManager;
        }

        public SelectList AllUsers { get; set; }

        public SelectList AllRoles { get; set; }
        [BindProperty]
        [Required]
        public string SelectedUserId { get; set; }
        [BindProperty]
        [Required]
        public string SelectedRole { get; set; }

        public IActionResult OnGet()
        {
            SetupUsersAndRoles();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                SetupUsersAndRoles();
                return Page();
            }

            IdentityUser user = UserManager.Users.FirstOrDefault(u => u.Id == SelectedUserId);
            if(user != null)
            {
                IdentityResult result = await UserManager.AddToRoleAsync(user, SelectedRole);

                if(result.Succeeded)
                {
                    return RedirectToPage("/Roles/Index");
                } else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    SetupUsersAndRoles();
                    return Page();
                }
            }

            ModelState.AddModelError("UserError", "User was not found");
            SetupUsersAndRoles();
            return Page();
        }
        private void SetupUsersAndRoles()
        {
            AllUsers = new SelectList(UserManager.Users.ToList(), "Id", "Email");
            AllRoles = new SelectList(RoleManager.Roles.ToList(), "Name", "Name");
        }
    }
}
