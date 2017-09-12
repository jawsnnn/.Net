using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;

namespace GradeBook.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        GradeBook test;
        GradeStatistics stats;
        public GradeBookTests()
        {
            test = new GradeBook();
            test.AddGrade(10);
            test.AddGrade(40);
            test.AddGrade(50);
            stats = test.ComputeStats();
        }
        [TestMethod]
        public void ComputeHighestGrades ()
        {            
            Assert.AreEqual(50, stats.MaxGrade);
        }

        [TestMethod]
        public void ComputeLowestGrades()
        {
            Assert.AreEqual(10, stats.MinGrade);
        }

        [TestMethod]
        public void ComputeAvgGrades()
        {
            Assert.AreEqual(33.33, stats.AvgGrade, 0.01);
        }
    }
}
