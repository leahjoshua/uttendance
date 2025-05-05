using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Parisa Nawar for CS 4485.0w1, CS Project, starting May 3, 2025
     * NetID: PXN210032
     * 
     * Class entity corresponding to the Answers table in the database.
     */
    public class Answers
    {
        [ForeignKey("FK_AnswerID")]
        public int FK_AnswerID { get; set; }

        [ForeignKey("FK_SubmissionID")]
        public int FK_SubmissionID { get; set; }
    }

}
