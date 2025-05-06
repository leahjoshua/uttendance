using student_website.Models;
using Microsoft.EntityFrameworkCore;

namespace student_website.Services
{
    public class SubmissionService
    {
        /* Written by Judy Yang and Parisa Nawar for CS 4485.0w1, CS Project, starting April 24, 2025
         * NetID: JXY200013, PXN210032
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

        // Function to insert Submission information to database
        public async Task CreateAndInsertSubmissionAsync(String userIP, int form, int studentID, List<int> answerIDs)
        {
            // Create a new Submission object
            var submission = new Submission
            {
                IPAddress = userIP,
                DateTime = DateTime.Now,
                FK_FormID = form,
                FK_UTDID = studentID
            };

            // Insert to database
            await InsertSubmissionAsync(submission);
            var subID = submission.SubmissionID;

            //Parisa Nawar on May 4

            //Create Answers objects and add them
            if (answerIDs != null || answerIDs.Count != 0)
            {
                foreach (var answerID in answerIDs)
                {
                    var answerRow = new Answers
                    {
                        FK_AnswerID = answerID,
                        FK_SubmissionID = subID
                    };

                    _context.Answers.Add(answerRow);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
