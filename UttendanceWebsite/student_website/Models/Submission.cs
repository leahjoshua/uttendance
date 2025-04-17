using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * parisa couple lines
        NetID: JXY200013
    */
    public class Submission
    {
        [Key]
        public int SubmissionID { get; set; }
        public string AttendanceStatus { get; set; } = "";
        public string IFName { get; set; } = "";
        public string ILName { get; set; } = "";
        public string IPAddress { get; set; } = "";
        public DateTime? DateTime { get; set; }
        [ForeignKey("FK_FormID")]
        public int? FK_FormID { get; set; }
        [ForeignKey("FK_UTDID")]
        public int? FK_UTDID { get; set; }
    }
}
