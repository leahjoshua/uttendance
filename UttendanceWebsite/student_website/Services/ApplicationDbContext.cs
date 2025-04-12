using Microsoft.EntityFrameworkCore;
using student_website.Models;

namespace student_website.Services
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 11, 2025
        NetID: JXY200013
    */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Answerchoice> Answerchoice { get; set; }
        public DbSet<Attends> Attends { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Submission> Submission { get; set; }
    }
}
