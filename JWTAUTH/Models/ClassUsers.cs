using JWTAUTH.IdentityAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Models
{
    public class ClassUsers
    {
        [ForeignKey("user")]
        public string User_ID { set; get; }
        public ApplicationUser user { set; get; }
        
        [ForeignKey("Class")]
        public int Class_ID { set; get; }
        public Classes Class { set; get; }
    }
}
