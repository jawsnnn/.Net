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
                NameChangedEventArgs args = new NameChangedEventArgs();
                args.ExistingName = _name;
                args.NewName = value;
                if (_name != value)
                {                    
                    onNameChanged(this, args);
                }
                if (!String.IsNullOrEmpty(value))
                {
                    WelcomeNewVal(this, args);
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate onNameChanged; // Test whether we can get away with declaring the delegate declaration in the same file
        public event NameChangedDelegate WelcomeNewVal;

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
