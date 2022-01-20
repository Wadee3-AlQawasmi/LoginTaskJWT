﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.IdentityAuth
{
    public class ApplicationUser: IdentityUser
    {
        public string fullname { set; get; }

    }
}
