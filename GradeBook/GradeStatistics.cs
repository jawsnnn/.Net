using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeStatistics
    {
        public float AvgGrade;
        public float MinGrade;
        public float MaxGrade;
        public GradeStatistics()
        {
            AvgGrade = 0;
            MinGrade = float.MaxValue;
            MaxGrade = 0;
        }
    }
}
