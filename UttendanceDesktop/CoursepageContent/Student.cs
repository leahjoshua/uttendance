/******************************************************************************
* Student Class for the UttendanceDesktop application.
* This class serves as an object to hold student information.
* Written by Joanna Yang(jxy210012) 
* for CS4485.0W1 at The University of Texas at Dallas starting March 14, 2025.
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop.CoursepageContent
{
    internal class Student
    {
        //Get and set for student's UTD-ID
        public int? SUTDID { get; set; }
        //Get and set for student's Net-ID
        public string? SNetID { get; set; }
        //Get and set for student's First Name
        public string? SFName { get; set; }
        //Get and set for student's Last Name
        public string? SLName { get; set; }
    }
}
