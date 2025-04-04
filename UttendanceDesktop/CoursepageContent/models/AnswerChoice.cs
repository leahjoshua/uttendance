using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop.CoursepageContent.models
{
    public class AnswerChoice
    {
        public int AnswerID { get; set; }
        public bool isCorrect { get; set; }
        public string? AnswerStatement { get; set; }
    }
}
