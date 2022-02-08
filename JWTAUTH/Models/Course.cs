using JWTAUTH.IdentityAuth;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Models
{
    public class Course
    {

        public int ID { set; get; }

        [Required]
        public string CourseName { set; get; }
        
        [Required]
        public string CourseCode { set; get; }

        

    }
}
