using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * parisa wrote couple
        NetID: JXY200013
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
