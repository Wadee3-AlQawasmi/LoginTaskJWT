using JWTAUTH.DbContext;
using JWTAUTH.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
    public class CourseService : ICourseService
    {
        ApplicationDbContext context;

        public CourseService(ApplicationDbContext _context)
        {
            context = _context;
        }
        
        public void Insert(Course course)
        {
            context.course.Add(course);
            context.SaveChanges();
        }

        public List<Course> Load()
        {
            List<Course> obj = context.Set<Course>().ToList();
            return obj;
        }
    }
}
