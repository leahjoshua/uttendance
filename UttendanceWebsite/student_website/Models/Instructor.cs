using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace student_website.Models
{
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
