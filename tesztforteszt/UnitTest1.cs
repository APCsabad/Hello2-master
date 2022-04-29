using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace tesztforteszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConsoleWrite()
        {
            //Arrange

            string vart = "Anyu";

            //Action

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); //console átirányításaaaaa

                teszt.Program.Main();
                var kapott = sw.ToString().Trim();

                // Assert 
                Assert.AreEqual(kapott, vart);
            }

            
        }
    }
}
