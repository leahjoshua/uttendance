using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * parisa wrote some lines
        NetID: JXY200013
    */
    public class Form
    {
        [Key]
        public int FormID { get; set; }
        public string PassWd { get; set; } = "";
        public DateTime? ReleaseDataTime { get; set; }
        public DateTime? CloseDateTime { get; set; }
        [ForeignKey("FK_CourseNum")]
        public int? FK_CourseNum { get; set; }
    }
}
