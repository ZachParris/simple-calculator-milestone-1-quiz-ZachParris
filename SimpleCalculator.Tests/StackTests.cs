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
    }
}
