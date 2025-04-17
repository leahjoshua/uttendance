using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
     * parisa couple lines
        NetID: JXY200013
    */
    public class Attends
    {
        public int FK_UTDID { get; set; }
        public int FK_CourseNum { get; set; }

        //Referenced Keys
        public Student Student { get; set; }  
        public Class Class { get; set; }
    }
}
