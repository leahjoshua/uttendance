/******************************************************************************
* AnswerChoice for the UttendanceDesktop application.
* 
* This class represents a row in the answerchoice table.
*
* Written by Leah Joshua (lej210003) 
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
    public class AnswerChoice
    {
        public int AnswerID { get; set; }
        public bool isCorrect { get; set; }
        public string? AnswerStatement { get; set; }
    }
}
