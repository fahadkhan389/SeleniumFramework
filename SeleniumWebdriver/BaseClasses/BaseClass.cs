using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomerException;
//using SeleniumWebdriver.CustomerException;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;

        }
        
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        

        [AssemblyInitialize]
        public static void Initwebdriver(TestContext tc)
        {
            ObjectRepo.config = new AppConfigReader();
            switch (ObjectRepo.config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepo.driver = GetChromeDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver not found " +ObjectRepo.config.GetBrowser().ToString() );
         
            }

            ObjectRepo.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepo.config.GetPageloadTime());
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepo.config.GetElementloadTime());
            BrowserHelper.MaximizeWindow();
        }
        [AssemblyCleanup]
        public static void TearDown()

        {
            if (ObjectRepo.driver != null)
            {
                ObjectRepo.driver.Close();
                ObjectRepo.driver.Quit();
            }
        }

    }
}
