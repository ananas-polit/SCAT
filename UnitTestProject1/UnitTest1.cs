using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCAT;
using SCAT.Forms;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ClassCalc main = new ClassCalc();
        [TestMethod]
        public void TestMethod1()
        {
            
            string Login = "1";
            string Password = " 12 ";
            main.Check(Login, Password);
            Assert.AreEqual(true, main.Check(Login, Password));

        }
    }
}
