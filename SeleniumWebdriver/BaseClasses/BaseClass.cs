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
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static FirefoxProfile GetFFOptions()
        {
            FirefoxProfile options = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();
            options = manager.GetProfile("default");
            return options;

        }
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;

        }
        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            return options;

        }

        private static IWebDriver GetFFDriver()
        {
            IWebDriver driver = new FirefoxDriver(GetFFOptions());
            return driver;
              }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        private static PhantomJSDriver GetPhantomJSDriver()
        {
            PhantomJSDriver driver = new PhantomJSDriver();
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
                case BrowserType.IExplorer:
                    ObjectRepo.driver = GetIEDriver();
                    break;
                case BrowserType.Firefox:
                     ObjectRepo.driver = GetFFDriver();
                    break;
                case BrowserType.PhantomJS:
                    ObjectRepo.driver = GetPhantomJSDriver();
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
