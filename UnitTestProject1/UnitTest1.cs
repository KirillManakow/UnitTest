using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp21;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(program.Perem(2, 4), 5);
        }
    }
}
