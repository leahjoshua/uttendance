using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using student_website.Models;

namespace student_website.Services
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 11, 2025
     * NetID: JXY200013
     * 
     * Configure the database connection with the models in this project.
     */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        // Entities
        public DbSet<Answerchoice> Answerchoice { get; set; }
        public DbSet<Attends> Attends { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<Has> Has { get; set; }
        public DbSet<Answers> Answers { get; set; }

        /* Written by Parisa Nawar for CS 4485.0w1, CS Project, starting April 16, 2025
         * NetID: PXN210032
         */
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

            /* Written by Judy Yang, JXY200013
             * Added keys to connect composite key for Has */
            // Composite Primary Key for Has
            modelBuilder.Entity<Has>()
                .HasKey(h => new { h.FK_FormID, h.FK_QuestionID });

            // Form Foreign Key for Has
            modelBuilder.Entity<Has>()
                .HasOne(h => h.Form)
                .WithMany(f => f.Has)
                .HasForeignKey(h => h.FK_FormID)
                .HasPrincipalKey(f => f.FormID);

            // Question Foreign Key for Has
            modelBuilder.Entity<Has>()
                .HasOne(h => h.Question)
                .WithMany(q => q.Has)
                .HasForeignKey(h => h.FK_QuestionID)
                .HasPrincipalKey(q => q.QuestionID);

            //Composite Primary Key for Answers
            modelBuilder.Entity<Answers>()
                .HasKey(a => new { a.FK_AnswerID, a.FK_SubmissionID });
        }
    }
}
