using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    public class Has
    {
        /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 24, 2025
         * NetID: JXY200013
         * 
         * Class entity corresponding to the Has table in the database.
         */
        public int FK_FormID { get; set; }
        public int FK_QuestionID { get; set; }

        //Referenced Keys
        public Form Form { get; set; }
        public Question Question { get; set; }
    }
}
