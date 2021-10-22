using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradePointApp
{
    public  class GradeHistory
    {
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int Score { get; set; }
        public string Grade { get; set; }
        public int GradeUnit { get; set; }
        public int WeightPoint { get; set; }
        public string Remark { get; set; }


        public GradeHistory(string courseCode, int courseUnit, int score, string grade, int gradeUnit, int weightPoint, string remark)
        {

            CourseCode = courseCode;
            CourseUnit = courseUnit;
            Score      = score;
            Grade      = grade;
            GradeUnit  = gradeUnit;
            WeightPoint= weightPoint;
            Remark     = remark;

        }

    }
}
