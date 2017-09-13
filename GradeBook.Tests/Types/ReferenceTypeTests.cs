using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void AddDaystoDateTime()
        {
            DateTime date = new DateTime(2017, 09, 13);
            date = date.AddDays(1);

            Assert.AreEqual(date, new DateTime(2017, 09, 14));
        }

        [TestMethod]
        public void TrimAString()
        {
            string x = " SCOTT ";
            x = x.Trim();

            Assert.AreEqual(x, "SCOTT");
        }

        [TestMethod]
        public void ValueTypesPassByRef()
        {
            int x = 10;
            IncrementNumber(ref x);
            Assert.AreEqual(x, 11);
        }

        void IncrementNumber(ref int y)
        {
            y = y + 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByRef()
        {
            GradeBook book1 = new GradeBook("Gradebook 1");
            GradeBook book2 = book1;

            ChangeBookName(ref book2);

            //Assert.AreEqual(book1.Name, book2.Name);
            Assert.AreEqual(book2.Name, "Changed name");
        }

        private void ChangeBookName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Changed name";
        }

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
