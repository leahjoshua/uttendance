using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop.CoursepageContent.models
{
    class QuestionModel
    {
        public int QuestionID { get; set; }
        public string? ProblemStatement { get; set; }
        public int FormID { get; set; }
    }
}
