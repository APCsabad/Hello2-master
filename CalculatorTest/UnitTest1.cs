using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        static int s = 4;
        calculator.Kalkulatorr cal = new calculator.Kalkulatorr();
        [TestMethod]
        public void Testosszead()
        {
            int vart = 8;
            int kapott = cal.kiir();
            Assert.AreEqual(vart, kapott);
        }
    }
}
