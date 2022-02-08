using JWTAUTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
   public interface IClassUserService
    {
        List<ClassUsers> LoadUserOfClass(int id);

        void Insert(ClassUsers obj);
    }
}
