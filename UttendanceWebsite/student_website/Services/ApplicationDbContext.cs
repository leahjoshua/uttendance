using Microsoft.EntityFrameworkCore;
using student_website.Models;

namespace student_website.Services
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 11, 2025
     * parisa added some lines
        NetID: JXY200013
    */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<Answerchoice> Answerchoice { get; set; }
        public DbSet<Attends> Attends { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<Instructor> Instructor { get; set; }

        //Deal with multiple primary keys (referenced)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite Primary Key for Attends
            modelBuilder.Entity<Attends>()
                .HasKey(a => new { a.FK_UTDID, a.FK_CourseNum });

            //Student Foreign Key for Attends
            modelBuilder.Entity<Attends>()
                .HasOne(a => a.Student)
                .WithMany(s => s.Attends)
                .HasForeignKey(a => a.FK_UTDID)
                .HasPrincipalKey(s => s.UTDID);

            //Class Foreign Key for Attends
            modelBuilder.Entity<Attends>()
                .HasOne(a => a.Class)
                .WithMany(c => c.Attends)
                .HasForeignKey(a => a.FK_CourseNum)
                .HasPrincipalKey(c => c.CourseNum); 
        }
    }
}
