using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.WebdriverWait
{[TestClass]
    public class TestWaitdriverWait
    {
        [TestMethod]
        public void TestWaitImplicit()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            LinkHelper.ClickLink(By.XPath("//div[@id='Eyebrow']/descendant::a[@href='https://mail.yahoo.com/?.intl=au&.lang=en-AU&.partner=none&.src=fp']"));


        }
        [TestMethod]
        public void TestDynamicDriverWait()
        {
            NavigationHelper.NavigatetoURL("https://www.udemy.com/");
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepo.driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //wait.Until(waitforsearchbox());
            wait.Until(WaitforTitle());

              }

        private Func<IWebDriver, bool> waitforsearchbox()
            {

            return ((x) =>
            {
                Console.WriteLine("Waiting for search box");
                return x.FindElements(By.XPath("//input[@type='search']")).Count == 1;

            });

}

        private Func<IWebDriver, string> WaitforTitle()

        {
            return ((x) =>
            {

                Console.WriteLine("Waiting for title");
                if (x.Title.Contains("Main"))
                    return x.Title;
                return null;

            });

        }

        [TestMethod]
        public void TestDynamicDefaultWait()
        {
            NavigationHelper.NavigatetoURL("https://www.udemy.com/");
            ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ObjectRepo.driver.FindElement(By.Id("")));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(ChangeofValue());
            
        }
        private Func<IWebElement, string> ChangeofValue()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for change value");
                SelectElement select = new SelectElement(x);
                if (select.SelectedOption.Text.Equals("major"))
                    return select.SelectedOption.Text;
                return null;


            });
        }
        

    [TestMethod]
    public void DynamicWaitExpecteConditionClass()
    {
        NavigationHelper.NavigatetoURL("https://www.udemy.com/");
        ObjectRepo.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        WebDriverWait wait = new WebDriverWait(ObjectRepo.driver, TimeSpan.FromSeconds(50));
        wait.PollingInterval = TimeSpan.FromMilliseconds(250);
        wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
        //wait.Until(waitforsearchbox());
        wait.Until(ExpectedConditions.ElementIsVisible(By.Id("")));

    }


}



}

