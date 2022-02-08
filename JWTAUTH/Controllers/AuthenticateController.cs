using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using JWTAUTH.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWTAUTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IRegisterService registerService;
        private readonly IConfiguration configuration;

        public AuthenticateController(IRegisterService _registerService, IConfiguration _configuration)
        {
            registerService = _registerService;
            configuration = _configuration;
            
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            var user = await registerService.FindByUsername(registerModel.Username);
            if (user != null)
            {
                return Ok( new Response { Status = "Error", Message = "User Already Exists" });
            }
            else
            {
                var result = await registerService.Create(registerModel);

                if (!result.Succeeded)
                {
                    return Ok(new Response { Status = "Error1", Message = "user creation failed" });
                }
                return Ok(new Response { Status = "Success", Message = "User Created Successfully" });
                
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var result = await registerService.Login(loginModel);

            if (result.Succeeded)
            {
                var user = await registerService.FindByUsername(loginModel.username);

                var authClaims = new List<Claim>
                   {
                        new Claim(ClaimTypes.Name,user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                    };

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]));

                var token = new JwtSecurityToken(
                    expires: DateTime.Now.AddDays(30),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
                
            }
            return Ok(new Response { Status = "Error", Message = "user Name Or Password Faild" });
        }

        [HttpGet]
        [Route("Load")]
        public IList<ApplicationUser> Load()
        {
            var result = registerService.Load();
            return result;
        }

        [HttpGet]
        [Route("Edit")]
        public Task<ApplicationUser> Edit(string username)
        {
            var user =  registerService.FindByUsername(username);
            return user;
        }
        
        [HttpGet]
        [Route("Delete")]
        public void Delete(string username)
        {
            registerService.DeleteUser(username);
        }


        [HttpPost]
        [Route("Update")]
        public void Update(RegisterModel registerModel)
        {
            registerService.Update(registerModel);
        }
        
    }
}
