namespace student_website.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
        NetID: JXY200013
    */
    public class Question
    {
        public int QuestionID { get; set; }
        public string ProblemStatement { get; set; } = "";
        public int? FK_FormID { get; set; }
    }
}
