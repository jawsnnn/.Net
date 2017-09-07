﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
    static void Main(string[] args)
        {
            GradeBook gb = new GradeBook();
            gb.AddGrade(10);
            gb.AddGrade(10.9F);


            GradeBook book2 = gb;
            book2.AddGrade(21.0F);

            GradeStatistics stats = gb.ComputeStats();
            Console.WriteLine("Min: " + stats.MinGrade + "|Max: " + stats.MaxGrade + "|Avg: " + stats.AvgGrade);
        }
    }
}