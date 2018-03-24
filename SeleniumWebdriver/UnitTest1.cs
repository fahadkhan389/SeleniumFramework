using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser:{0}", config.GetBrowser());
            Console.WriteLine("Browser:{0}", config.GetUsername());
            Console.WriteLine("Browser:{0}", config.GetPassword());
        }
    }
}


//    Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
//    Console.WriteLine((int)BrowserType.Firefox);
//    Console.WriteLine((int)BrowserType.IExplorer);
//    IWebDriver driver = new ChromeDriver();
//    driver.Navigate().GoToUrl("http://www.youtube.com");
//    driver.Close();
//    driver.Quit();
//}
