using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
   public interface IRegisterService
    {
        Task<ApplicationUser> FindByUsername(string username);

        Task<IdentityResult> Create(RegisterModel registerModel);
 
        Task<SignInResult> Login(LoginModel loginModel);

        IList<ApplicationUser> Load();

        Task<IdentityResult> DeleteUser(string userName);

        void Update(RegisterModel registerModel);
    }
}
