using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackCanBeCreated()
        {
            Stack tester = new Stack();
            Assert.IsNotNull(tester);
        }
        [TestMethod]
        public void StackHandlesLastEquation()
        {
            Stack tester = new Stack();
            tester.lastInput = "1+2";
            Assert.AreEqual("1+2", tester);
        }
        [TestMethod]
        public void StackHandlesLastAnswer()
        {
            Stack tester = new Stack();
            tester.lastResult = 4; 
            Assert.AreEqual(4, tester);
        }
    }
}
