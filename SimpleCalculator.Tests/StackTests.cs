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
        public void CanGetLastEquation()
        {
            Stack tester = new Stack();
            Assert.IsNotNull(tester.lastInput);
        }
        [TestMethod]
        public void CanGetLastAnswer()
        {
            Stack tester = new Stack();
            Assert.IsNotNull(tester.lastResult);
        }
    }
}
