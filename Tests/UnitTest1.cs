using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;


namespace Tests
{
    [TestClass]
    public class OverallTests
    {
        public string URL = "https://www.pluralsight.com/";

        [TestMethod]
        public void Go_to_Home_page()
        {
            Pages.HomePage.Goto(URL);
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestCleanup]
        public  void TidyUPATEND()
        {
            Pages.HomePage.Close();
        }
    }
}
