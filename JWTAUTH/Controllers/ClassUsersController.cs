using JWTAUTH.Models;
using JWTAUTH.Services;
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
    public class ClassUsersController : ControllerBase
    {
        IClassUserService classUserService;
        public ClassUsersController(IClassUserService _classUserService)
        {
            classUserService = _classUserService;
        }

        [HttpPost]
        [Route("Insert")]
        public void Insert(ClassUsers obj)
        {
            classUserService.Insert(obj);
        }



        [HttpGet]
        [Route("LoadUserOfClass")]
        public List<ClassUsers> LoadUserOfClass(int id)
        {
            var result = classUserService.LoadUserOfClass(id);
            return result;
        }
    }
}
