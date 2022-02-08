using JWTAUTH.DbContext;
using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using JWTAUTH.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        IClassService classService;
        ApplicationDbContext context;
        
        public ClassController(IClassService _classService,ApplicationDbContext _context)
        {
            classService = _classService;
            context = _context;
        }
       
        [HttpPost]
        [Route("Insert")]
        public void Insert(Classes classes)
        {
            classService.Insert(classes);
        }

        [HttpGet]
        [Route("LoadAllClasses")]
        public List<Classes> LoadAllClasses()
        {
            var result = classService.LoadAllClasses();
            return result;         
        }

        [HttpGet]
        [Route("Edit")]
        public IQueryable<Classes> Edit(int id)
        {
            var result = classService.Edit(id);
            return result;
        }
        
        [HttpPost]
        [Route("Update")]
        public void Update(Classes obj)
        {
            classService.Update(obj);
        }


    }
}
