using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook;
using System.IO;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook gb = InitializeGradeBook();
            AddGrades(gb);
            WriteGrades(gb);
            DisplayStats(gb);
            //Console.WriteLine("Min: " + stats.MinGrade + "|Max: " + stats.MaxGrade + "|Avg: " + stats.AvgGrade);
        }

        private static void DisplayStats(GradeBook gb)
        {
            GradeStatistics stats = gb.ComputeStats();
            WriteResults("Average", stats.AvgGrade);
            WriteResults("Minimum grade", stats.MinGrade);
            WriteResults("Maximum grade", stats.MaxGrade);
        }

        private static void WriteGrades(GradeBook gb)
        {
            using (StreamWriter f = File.CreateText("Results.txt"))
            {
                gb.WriteGrades(f);
            }
        }

        private static void AddGrades(GradeBook gb)
        {
            gb.AddGrade(10);
            gb.AddGrade(10.9F);
            gb.AddGrade(21.0F);
        }

        static int validateGradeBookName(GradeBook book, string name)
        {
            try
            {
                book.Name = name;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        private static GradeBook InitializeGradeBook()
        {
            GradeBook gb = new GradeBook("My gradebook");
            gb.onNameChanged += ChangingName;
            gb.WelcomeNewVal += ChangedName;

            string book_name;
            do
            {
                Console.WriteLine("Enter a gradebook name");
                book_name = Console.ReadLine();
            } while (validateGradeBookName(gb, book_name) == 1);
            Console.WriteLine(gb.Name);
            return gb;
        }

        static void WriteResults(string desc, float result)
        {
            Console.WriteLine(desc + ": " + result);
        }
        static void ChangingName(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Try changing name from {args.ExistingName} to {args.NewName}");
        }
        static void ChangedName(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Changed name to {args.NewName}");
        }
    }
}
