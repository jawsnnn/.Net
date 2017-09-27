using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public abstract class GradeTracker
    {
        protected string _name;

        public event NameChangedDelegate onNameChanged; // Test whether we can get away with declaring the delegate declaration in the same file
        public event NameChangedDelegate WelcomeNewVal;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name of gradebook cannot be null");
                }
                NameChangedEventArgs args = new NameChangedEventArgs();
                args.ExistingName = _name;
                args.NewName = value;
                if (_name != value)
                {
                    onNameChanged(this, args);
                }
                WelcomeNewVal(this, args);
                _name = value;
            }
        }

        public abstract void WriteGrades(TextWriter destination);
        public abstract GradeStatistics ComputeStats();
        public abstract void AddGrade(float grade);
    }
}
