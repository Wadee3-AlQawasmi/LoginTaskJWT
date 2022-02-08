using JWTAUTH.DbContext;
using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
    public class ClassService : IClassService
    {
        ApplicationDbContext context;
        public ClassService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IQueryable<Classes> Edit(int id)
        {
            var result = context.classes.Include(x => x.course).Where(x => x.ID == id);
            return result;
        }

        public void Insert(Classes classes)
        {
            context.classes.Add(classes);
            context.SaveChanges();
        }

        public List<Classes> LoadAllClasses()
        {
            List<Classes> result = context.classes.Include(x => x.course).ToList();
            return result;
        }

        public void Update(Classes obj)
        {
            var result= context.classes.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        
    }
}
