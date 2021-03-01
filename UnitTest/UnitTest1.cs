using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorldConsole.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(result, "Hello World!");
            }
        }
    }
}
