  using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void ConstCanBeInstantiated()
        {
            Constants tester = new Constants();
            Assert.IsNotNull(tester);
        }
        [TestMethod]
        public void ConstantsCanBeAddedToDictionary()
        {
            Constants tester = new Constants();
            tester.AddConstantsToDictionary("x", 1);
            Assert.AreEqual(tester.GetConstant("x"), 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionThrownForExistingVar()
        {
            Constants tester = new Constants();
            tester.AddConstantsToDictionary("x", 1);
            tester.AddConstantsToDictionary("x", 2);
        }
    }
}
