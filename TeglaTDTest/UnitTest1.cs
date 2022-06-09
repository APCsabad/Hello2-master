using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TéglaTD;

namespace TeglaTDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFelszin()
        {
            Tegla tegla = new Tegla(1, 2, 3);
            int vart = 9;
            int kapott = tegla.getFelszin();
            Assert.AreNotEqual(vart, kapott);
        }

        [TestMethod]
        public void felszinTestRossz() 
        {
            Tegla tegla = new Tegla(1, 2, 3);
            int vart = 6;
            int kapott = tegla.getFelszin();
            Assert.AreNotEqual(vart, kapott);

        }
        [TestMethod]
        public void tesztterfogat()
        {
            Tegla tegla = new Tegla(2, 3, 4);
            int vart = 24;
            int kapott = tegla.getTerfogat();
            Assert.AreEqual(vart, kapott);

        }
        public void tesztterfogatrossz()
        {
            Tegla tegla = new Tegla(1, 2, 3);
            int vart = 17;
            int kapott = tegla.getTerfogat();
            Assert.AreNotEqual(vart, kapott);

        }
    }
}
