using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBook
    {

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public int index;
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeBook(string name)
        {
            grades = new List<float>();
            Name = name;
        }

        public GradeStatistics ComputeStats()
        {
            GradeStatistics stats = new GradeStatistics();
            foreach (float grade in grades)
            {
                if (stats.MinGrade > grade) 
                {
                    stats.MinGrade = grade;
                }
                if (stats.MaxGrade < grade)
                {
                    stats.MaxGrade = grade;
                }
                stats.AvgGrade = stats.AvgGrade + grade;
            }
            stats.AvgGrade = stats.AvgGrade / grades.Count;
            
            return stats;
        }
        
         public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
    }
}
