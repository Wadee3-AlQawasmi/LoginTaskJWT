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
    public class ClassUserService : IClassUserService
    {
        ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public ClassUserService(ApplicationDbContext _context, UserManager<ApplicationUser> _userManager)
        {
            context = _context;
            userManager = _userManager;
        }

        public void Insert(ClassUsers obj)
        {
            context.classUsers.Add(obj);
            context.SaveChanges();
        }


        public List<ClassUsers> LoadUserOfClass(int id)
        {
            //  var result = context.classUsers.Where(x => x.Class_ID == id).ToList();
            var result = context.classUsers.Join(userManager.Users,
                                                 c => c.User_ID,
                                                 u => u.Id,
                                                 (c, u) => new ClassUsers
                                                 {
                                                     User_ID = u.UserName,
                                                     Class_ID = c.Class_ID
                                                 }).Where(x=>x.Class_ID== id).ToList();
            return result;
        }

        
    }
}
