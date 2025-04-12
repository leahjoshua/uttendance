namespace student.api.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
        NetID: JXY200013
    */
    public class Form
    {
        public int FormID { get; set; }
        public string PassWd { get; set; } = "";
        public DateTime? ReleaseDataTime { get; set; }
        public DateTime? CloseDateTime { get; set; }
        public int? FK_CourseNum { get; set; }

    }
}
