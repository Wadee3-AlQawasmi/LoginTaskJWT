using JWTAUTH.IdentityAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Models
{
    public class Classes
    {
        public int ID { set; get; }

        public string StartDate { set; get; }

        public string EndDate { set; get; }

        [ForeignKey("course")]
        public int Course_id { set; get; }
        public virtual Course course { set; get; }



    }
}
