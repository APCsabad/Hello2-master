using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tesztttt
{
    [TestClass]
    public class UnitTest1
    {
        static double s = 2.0;

        negyszog.Negyszog nsz = new negyszog.Negyszog(s);
        [TestMethod]
        public void TestKerulet()
        {
            double vart = 8.0;
            double kapott = nsz.kerulet();
            Assert.AreEqual(vart,kapott);

        }
        [TestMethod]
        public void TestTerulet() {
            double vart = 4.0;
            double kapott = nsz.terulet();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TestAtlo() {
            double vart = 2.83 ;
            double kapott = nsz.atlo();
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]

        public void TesztOszlop() {
            double m = 0;
            objNegyszog.setOszlop(m);
        }
    }
}
