using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace AppProject.Models
{
    public class AdminUserContext : IdentityDbContext<IdentityUser>
    {
        public AdminUserContext(DbContextOptions<AdminUserContext> options) : base(options)
        {
            
        }
    }
}