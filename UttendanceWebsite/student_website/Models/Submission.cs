namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
        NetID: JXY200013
    */
    public class Submission
    {
        public int SubmissionID { get; set; }
        public string AttendanceStatus { get; set; } = "";
        public string IFName { get; set; } = "";
        public string ILName { get; set; } = "";
        public string IPAddress { get; set; } = "";
        public DateTime? DateTime { get; set; }
        public int? FK_FormID { get; set; }
        public int? FK_UTDID { get; set; }
    }
}
