using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppProject.Models;

    public class ApplicationController : DbContext
    {
        public ApplicationController (DbContextOptions<ApplicationController> options)
            : base(options)
        {
        }

        public DbSet<AppProject.Models.Trainee> Trainee { get; set; }
    }
