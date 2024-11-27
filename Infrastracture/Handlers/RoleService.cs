using Application.Abstraction.Services.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Handlers
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RoleService(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async void CreateAdminRole()
        {
            if (await _roleManager.RoleExistsAsync("admin") == false)
            {
                await _roleManager.CreateAsync(new("admin"));
                    await _roleManager.CreateAsync(new("manager"));
            }
        }

        public async void CreateUserRole(string email, string roleName)
        {
           var emailExists = await _userManager.FindByEmailAsync(email);
            if (emailExists != null)
            {
                await _userManager.AddToRoleAsync(emailExists, roleName);
            }
        }
    }
}
