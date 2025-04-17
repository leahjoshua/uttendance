using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * parisa wrote some lines
        NetID: JXY200013
    */
    public class Instructor
    {
        [Key] 
        [Column("INetID")]
        public string INetID { get; set; }

        [Column("IFName")]
        public string IFName { get; set; }

        [Column("ILName")]
        public string ILName { get; set; }

        [Column("IPassword")]
        public string IPassword { get; set; }
    }
}
