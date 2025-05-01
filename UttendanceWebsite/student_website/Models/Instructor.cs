using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace student_website.Models
{
    /* Written by Parisa Nawar for CS 4485.0w1, CS Project, starting April 10, 2025
     * NetID: PXN210032
     * 
     * Class entity corresponding to the Instructor table in the database.
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
