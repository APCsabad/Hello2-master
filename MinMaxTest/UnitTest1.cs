using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MinMaxTest {
    [TestClass]
    public class UnitTest1 {
        MinMax.Adat adat = new MinMax.Adat();
        
        [TestMethod]
        public void MinTest() {
            adat.setNumber(false, new int[] { 1, 2, 3 });
            int expected = 1;
            int actual = adat.min();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxTest() {
            adat.setNumber(false, new int[] { 1, 2, 3 });
            int expected = 3;
            int actual = adat.max();
            Assert.AreEqual(expected, actual);
        }
    }
}
