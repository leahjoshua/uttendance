using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * Parisa Nawar wrote some lines for successful connection
     * NetID: JXY200013 and PXN210032
     * 
     * Class entity corresponding to the Class table in the database.
     */
    public class @Class
    {
        [Key]
        public int CourseNum { get; set; }
        public int? SectionNum { get; set; }
        public string ClassSubject { get; set; } = "";
        public int? ClassNum { get; set; }
        public string ClassName { get; set; } = "";
        public int? FK_ImageID { get; set; }
        [ForeignKey("FK_ImageID")]

        //Referenced Keys
        public ICollection<Attends> Attends { get; set; }
    }
}
