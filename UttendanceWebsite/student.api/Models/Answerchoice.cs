namespace student.api.Models
{
    /* Written by Judy Yang for CS 4485.0w1, CS Project, starting April 10, 2025
        NetID: JXY200013
    */
    public class Answerchoice
    {
        public int AnswerID { get; set; }
        public int? AnswerStatement { get; set; }
        public int? IsCorrect { get; set; }
        public int? FK_QuestionID { get; set; }
    }
}
