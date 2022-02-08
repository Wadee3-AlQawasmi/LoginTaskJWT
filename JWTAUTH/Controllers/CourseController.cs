using JWTAUTH.DbContext;
using JWTAUTH.Models;
using JWTAUTH.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
   
    {
        ICourseService courseService;
        public CourseController(ICourseService _courseService)
        {
            courseService = _courseService;
        }

        [HttpPost]
        [Route("InsertCourse")]
        public void Insert(Course course)
        {
            courseService.Insert(course);
        }

        [HttpGet]
        [Route("LoadCourse")]
        public List<Course> Load()
        {
            List<Course> courses = courseService.Load();
            return courses;
        }
    }
}

