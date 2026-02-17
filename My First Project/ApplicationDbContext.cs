using Microsoft.EntityFrameworkCore;
using My_First_Project.Models;

namespace My_First_Project
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        { 

        }
        public virtual DbSet<StudentModel> Students { get; set; }

    }
}
