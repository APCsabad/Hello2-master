using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace haromottest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, ExpectedException(typeof(FormatException))]
        public void szamtest()
        {
            haromot.Program.Main();

        }
    }
}
