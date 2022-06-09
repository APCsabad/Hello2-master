using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Szigettest
{
    [TestClass]
    public class UnitTest1
    {
        SzigetekUT.Sziget sziget = new SzigetekUT.Sziget();
            [TestMethod]
            public void Testszigetszam()
            {
                int vart = 4;
                int kapott = sziget.forsziget()[0];
                Assert.AreEqual(vart, kapott);
            }
        }
    } 

