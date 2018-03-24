using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.MultipleBrowsers
{[TestClass]
    public class TestMultippleBrowserWindow
    {
        [TestMethod]
        public void MultipleBrowserTest()
        {
            ObjectRepo.driver.Navigate().GoToUrl("https://www.w3schools.com/js/js_popup.asp");
            LinkHelper.ClickLink(By.XPath("//div[@id='mainLeaderboard']/following-sibling::div[position()=5]/a"));
            BrowserHelper.SwitchWindow(1);
            ObjectRepo.driver.Navigate().GoToUrl("https://www.w3schools.com/js/js_popup.asp");
            LinkHelper.ClickLink(By.XPath("//div[@id='mainLeaderboard']/following-sibling::div[position()=5]/a"));
            BrowserHelper.SwitchWindow(2);
            LinkHelper.ClickLink(By.XPath("//button[text()='Run »']"));



        }
        [TestMethod]
        public void TestFrame()
        {
            ObjectRepo.driver.Navigate().GoToUrl("https://www.w3schools.com/js/js_popup.asp");
            LinkHelper.ClickLink(By.XPath("//div[@id='mainLeaderboard']/following-sibling::div[position()=5]/a"));
            BrowserHelper.SwitchWindow(1);
            BrowserHelper.SwitchFrame(By.XPath("//iframe[@id='iframeResult']"));
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));

        }
    }
    }
