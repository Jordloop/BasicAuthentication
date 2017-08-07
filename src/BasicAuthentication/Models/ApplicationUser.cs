using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Used for managing users
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BasicAuthentication.Models
{
    //Identity comes with a class to represent a user 'IdentityUser'
    public class ApplicationUser : IdentityUser
    {

    }
}
