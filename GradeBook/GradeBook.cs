using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBook : GradeTracker
    {
        public override void WriteGrades(TextWriter destination)
        {
            int i = 0;
            for (Console.WriteLine("Printing grades"); i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }        

        public int index;
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        public GradeBook(string name)
        {
            grades = new List<float>();
            _name = name;
        }

        public override GradeStatistics ComputeStats()
        {
            Console.WriteLine("GradeBook::ComputeStats");

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

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        protected List<float> grades;
    }
}
