using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop.CoursepageContent.models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string ProblemStatement { get; set; }
        public List<AnswerChoice> AnswerChoices { get; set; }
        public bool IsSelected { get; set; }
    }
}
