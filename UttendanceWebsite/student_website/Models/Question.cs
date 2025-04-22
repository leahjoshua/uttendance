using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * Parisa Nawar wrote lines 14 and 17 for successful connection
     * NetID: JXY200013 and PXN210032
     * 
     * Class entity corresponding to the Question table in the database.
     */
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        public string ProblemStatement { get; set; } = "";
        [ForeignKey("FK_FormID")]
        public int? FK_FormID { get; set; }
    }
}
