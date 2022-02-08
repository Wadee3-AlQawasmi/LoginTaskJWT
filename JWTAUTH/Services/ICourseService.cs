using JWTAUTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
   public interface ICourseService
    {
        void Insert(Course course);

        List<Course> Load();
    }
}
