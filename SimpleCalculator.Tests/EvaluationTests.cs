using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluationTests
    {
        [TestMethod]
        public void CanBeInstantiated()
        {
            Evaluation test = new Evaluation();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void EvaluateAddExpAnswerCorrect()
        {
            Evaluation evaluate = new Evaluation();
            Assert.AreEqual(evaluate, evaluate.answer);
        }
    }
}
