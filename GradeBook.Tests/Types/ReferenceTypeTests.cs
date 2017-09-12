using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void StringCompare()
        {
            string name1 = "Arpan";
            string name2 = "arpan";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void IntVariablesStoreValues()
        {
            int x = 10;
            int y = x;

            x = 20;
            Assert.AreNotEqual(x, y);
        }
        [TestMethod]
        public void GradeBookStoresReference()
        {
            GradeBook g1 = new GradeBook("My Gradebook");
            GradeBook g2 = g1;

            g1.Name = "That Gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
