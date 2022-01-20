using JWTAUTH.DbContext;
using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public RegisterService (UserManager<ApplicationUser> _userManager,
                                SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        

        public async Task<IdentityResult> Create(RegisterModel registerModel)
        {
            var result = new ApplicationUser();
            ApplicationUser user = new ApplicationUser()
            {
                UserName = registerModel.Username,
                Email = registerModel.Email,
                PhoneNumber = registerModel.PhoneNumber,
                fullname = registerModel.FullName
            };

            var userResult = await userManager.CreateAsync(user, registerModel.Password);
        
            if(userResult.Succeeded)
            {
                return userResult;
                
            }
            return userResult;
        }

        public async Task<IdentityUser> FindByUsername(string username)
        {
            var result = await userManager.FindByNameAsync(username);
            return result;
        }

        public async Task<SignInResult> Login(LoginModel loginModel)
        {
            var result = await signInManager.PasswordSignInAsync(loginModel.username, loginModel.password, false, false);
            return result;
        }
    }
}
