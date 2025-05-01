using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UttendanceDesktop.CoursepageContent.models
{
    class QuestionBank
    {
        public int BankID { get; set; }

        public String BankTitle { get; set; }

        public QuestionItem.QuestionItem[] QuestionBankList { get; set; }
    }
}
