/******************************************************************************
* Question for the UttendanceDesktop application.
* 
* This class represents a row in the question table. Includes an extra 
* property IsSelected for the QuestionItem user control.
*
* Written by Leah Joshua (lej210003) 
* and Aendri Singh (axs210369)
* for CS4485.0W1 at The University of Texas at Dallas
* starting April 3, 2025.
******************************************************************************/

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
