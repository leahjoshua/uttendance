using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * parisa wrote some lines
        NetID: JXY200013
    */
    public class Student
    {
        [Key]
        public int UTDID { get; set; }
        public string SNetID { get; set; } = "";
        public string SFName { get; set; } = "";
        public string SLName { get; set; } = "";

        //Reference Keys
        public ICollection<Attends> Attends { get; set; }
    }
}
