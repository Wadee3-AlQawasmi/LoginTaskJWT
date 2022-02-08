using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Services
{
   public interface IClassService
    {
        void Insert(Classes classes);

        List<Classes> LoadAllClasses();

        IQueryable<Classes> Edit(int id);

        void Update(Classes obj);

    }

}
