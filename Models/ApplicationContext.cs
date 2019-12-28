using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppProject.Models
{

    public class  ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<AppProject.Models.Trainee> Trainees{ get; set;}
       public DbSet<District> Districts  { get; set;}

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {  /*
           modelBuilder.Entity<TraineeID>()
                       .Property(e => e.TraineeType)
                       .HasConversion(v => v.ToString(), v => (TraineeType) Enum.Parse(typeof(TraineeType),v));
          modelBuilder.Entity<TraineeID>()
                      .Property(e => e.Course_Name)
                      .HasConversion( v => v.ToString(), v => (Course)Enum.Parse(typeof(Course),v));

         modelBuilder.Entity<TraineeID>()
                     .Property(e => e.BloodGroup)
                     .HasConversion( e => e.ToString(), e =>(BloodGroup)Enum.Parse(typeof(BloodGroup),e));
         modelBuilder.Entity<TraineeID>()
                     .Property(e => e.MaritalStatus)
                     .HasConversion( v => v.ToString(),v => (MaritalStatus)Enum.Parse(typeof(MaritalStatus),v));
        modelBuilder.Entity<TraineeID>()
                    .Property( e => e.NameOfCadre)
                    .HasConversion( v => v.ToString(), v => (Cadre)Enum.Parse(typeof(Cadre),v)); 
        modelBuilder.Entity<Trainee>()
                    .Property(e => e.HomeDistrict)
                    .HasConversion(v => v.ToString(), v => (District)Enum.Parse(typeof(District),v));
           
                     */
       }
    }


}