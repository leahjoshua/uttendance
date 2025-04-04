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
        public string? PassWd { get; set; }
        public string? ReleaseDateTime { get; set; }
        public string? CloseDateTime { get; set; }
        public int CourseNum { get; set; }
        public List<Question>? Questions { get; set; }
    }
}
