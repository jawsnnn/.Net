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
            GradeBook gb = new GradeBook("My gradebook");

            gb.Name = null;

            Console.WriteLine(gb.Name);
            gb.AddGrade(10);
            gb.AddGrade(10.9F);

            GradeBook book2 = gb;
            book2.AddGrade(21.0F);

            gb.WriteGrades(Console.Out);

            GradeStatistics stats = gb.ComputeStats();
            WriteResults("Average", stats.AvgGrade);
            WriteResults("Minimum grade", stats.MinGrade);
            //Console.WriteLine("Min: " + stats.MinGrade + "|Max: " + stats.MaxGrade + "|Avg: " + stats.AvgGrade);
        }

    static void WriteResults(string desc, float result)
        {
            Console.WriteLine(desc + ": " + result);
        }
    }
}
