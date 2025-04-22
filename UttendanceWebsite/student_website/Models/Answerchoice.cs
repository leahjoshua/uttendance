using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * Parisa Nawar wrote lines 14 and 22 for successful connection
     * NetID: JXY200013 and PXN210032
     * 
     * Class entity corresponding to the Answerchoice table in the database.
     */
    public class Answerchoice
    {
        [Key]
        public int AnswerID { get; set; }

        public string AnswerStatement { get; set; }
        public bool? IsCorrect { get; set; }

        public int? FK_QuestionID { get; set; }

        [ForeignKey("FK_QuestionID")]
        public Question Question { get; set; }
    }
}
