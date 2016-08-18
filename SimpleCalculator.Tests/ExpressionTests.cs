using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        public void ExpCanBeInstantiated()
        {
            Expression expNotNull = new Expression();
            Assert.IsNotNull(expNotNull);
        }

        [TestMethod]
        public void CaptureFirstTerm()
        {
            Expression tester = new Expression();
            tester.Parser("1+2");
            Assert.AreEqual(1, tester.term_1);
        }

        [TestMethod]
        public void CaptureOperator()
        {
            Expression opTester = new Expression();
            opTester.Parser("1+2");
            Assert.AreEqual("+", opTester._operator);
        }

        [TestMethod]
        public void CatureSecondTerm()
        {
            Expression tester = new Expression();
            tester.Parser("1+2");
            Assert.AreEqual(2, tester.term_2);
        }
    }
}
