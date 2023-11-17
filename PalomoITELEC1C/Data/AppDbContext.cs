using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PalomoITELEC1C.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PalomoITELEC1C.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "JakobNew",
                    LastName = "Palomo",
                    Birthday = DateTime.Parse("12/08/2002"),
                    Major = Major.BSIT,
                    Email = "jakob@gmail.com"
                },
                 new Student()
                {
                Id = 2,
                    FirstName = "Edmond",
                    LastName = "Garraton",
                    Birthday = DateTime.Parse("12/12/2002"),
                    Major = Major.BSIT,
                    Email = "fhourze@gmail.com"
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Jakob",
                    LastName = "Palomo",
                    IsTenured = true,
                    Phone="00-3333-3333",
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("05/05/2023")
                },
            new Instructor()
                {
                    Id = 2,
                    FirstName = "Zeke",
                    LastName = "Gonzalez",
                    IsTenured = true,
                    Phone = "00-3333-3333",
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("05/05/2023")
                }
            );
        }

    }
}
