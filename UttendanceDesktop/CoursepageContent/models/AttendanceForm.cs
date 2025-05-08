/******************************************************************************
* AttendanceForm for the UttendanceDesktop application.
* 
* This class represents a row in the form table. Includes extra proprties
* for total students in the class which the form belongs to and total number
* of submissions for the form.
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
    public class AttendanceForm
    {
        public int FormID { get; set; }
        public string PassWd { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public DateTime CloseDateTime { get; set; }
        public int CourseNum { get; set; }
        public List<Question> Questions { get; set; }

        public int TotalSubmissions { get; set; }
        public int TotalStudents { get; set; }
    }
}
