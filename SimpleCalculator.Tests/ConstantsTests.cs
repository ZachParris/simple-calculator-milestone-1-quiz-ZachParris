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
            Assert.AreEqual("x=1", tester);
        }
    }
}
