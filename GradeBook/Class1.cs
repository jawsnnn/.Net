using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook;

namespace GradeBook
{
    class Program
    {
    static void Main(string[] args)
        {
            GradeBook gb = new GradeBook();

            gb.onNameChanged += OutputChanges;
            gb.WelcomeNewVal += ChangeSuccess;
            
            gb.Name = "My GradeBook";
            gb.Name = "GradeBookName";


            gb.Name = null; // doesn't work anymore because setter doesn't allow it
            Console.WriteLine(gb.Name);
            gb.AddGrade(10);
            gb.AddGrade(10.9F);

            GradeBook book2 = gb;
            book2.AddGrade(21.0F);

            GradeStatistics stats = gb.ComputeStats();
            WriteResults("Average", stats.AvgGrade);
            WriteResults("Minimum grade", stats.MinGrade);
            WriteResults("Maximum grade", (int)stats.MaxGrade);
            //Console.WriteLine("Min: " + stats.MinGrade + "|Max: " + stats.MaxGrade + "|Avg: " + stats.AvgGrade);
        }

    static void WriteResults(string desc, float result)
        {
            Console.WriteLine(desc + ": " + result);
        }
    static void WriteResults(string desc, int result)
        {
            Console.WriteLine($"{desc} --> {result}");
        }
    static void OutputChanges (object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Tryinng to change {args.ExistingName} to {args.NewName}");
        }
        static void ChangeSuccess(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Goodbye {args.ExistingName} Welcome {args.NewName}");
        }
    }
}
