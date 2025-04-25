using student_website.Models;
using Microsoft.EntityFrameworkCore;

namespace student_website.Services
{
    public class SubmissionService
    {
        /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 24, 2025
         * NetID: JXY200013
         * 
         * Service for Submission to handle databse interactions
         */
        private readonly ApplicationDbContext _context;

        public SubmissionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InsertSubmissionAsync(Submission submission)
        {
            try
            {
                // Don't need to set SubmissionID because it is automatic

                // Set attendance to be true when students press button
                submission.AttendanceStatus = "P";

                // Add submission
                _context.Submission.Add(submission);

                // Save changes to database
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                throw new InvalidOperationException("Error in inserting submission: ", e);
            }
        }

        // Can be called in different components and don't need to rewrite
        public async Task CreateAndInsertSubmissionAsync(String userIP, int form, Student student)
        {
            var submission = new Submission
            {
                IPAddress = userIP,
                DateTime = DateTime.Now,
                FK_FormID = form,
                FK_UTDID = student.UTDID
            };

            // Insert to database
            await InsertSubmissionAsync(submission);
        }
    }
}
