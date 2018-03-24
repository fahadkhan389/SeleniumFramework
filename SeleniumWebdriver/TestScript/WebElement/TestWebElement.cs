using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.WebElement
{[TestClass]
  public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            ObjectRepo.driver.FindElement(By.Id("search")).SendKeys("my video");
            ObjectRepo.driver.FindElement(By.XPath("//button[@id='search-icon-legacy']")).Click();
            ObjectRepo.driver.FindElement(By.XPath("//button[@id='search-icon-legacy']")).Click();

        }
        [TestMethod]
        public void GetDesiredCap()
        {
            DesiredCapability.GetDesiredCapabilities();
        }

        

    }
}
