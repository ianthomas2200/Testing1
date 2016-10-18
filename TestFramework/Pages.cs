using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static IWebDriver driver = new ChromeDriver(@"C:\TestTools");
            public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            public static void Goto(string URL1)
            {
                log.Error("----------");
                driver.Url = URL1;
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
            }

            public static bool IsAt()
            {
                string requiredpagetitle = "Pluralsight | Unlimited Online Developer, IT and Creative Training";
                string pagetitle = driver.Title;
                log.Info("test");
                log.Info(pagetitle);
                return requiredpagetitle == driver.Title;
            }

            public static void Close()
            {
                driver.Close();
            }

        }
    }

}
