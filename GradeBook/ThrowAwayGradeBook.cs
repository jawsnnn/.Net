using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)
        {
            this.grades = new List<float>();
            this._name = name;
        }

        public event NameChangedDelegate onNameChanged; // Test whether we can get away with declaring the delegate declaration in the same file
        public event NameChangedDelegate WelcomeNewVal;

        public override GradeStatistics ComputeStats()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStats");
            float minGrade = float.MaxValue;
            foreach (float grade in this.grades)
            {
                minGrade = Math.Min(grade, minGrade);
            }
            grades.Remove(minGrade);

            return base.ComputeStats();
        }
    }
}
