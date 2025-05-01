using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * Parisa Nawar wrote lines 13, 18, and 21-22 for successful connection
     * NetID: JXY200013 and PXN210032
     * 
     * Class entity corresponding to the Form table in the database.
     */
    public class Form
    {
        [Key]
        public int FormID { get; set; }
        public string PassWd { get; set; } = "";
        public DateTime? ReleaseDateTime { get; set; }
        public DateTime? CloseDateTime { get; set; }
        [ForeignKey("FK_CourseNum")]
        public int? FK_CourseNum { get; set; }

        //Referenced Keys
        public ICollection<Has> Has { get; set; }
    }
}
