using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
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
            TextBoxHelper.EnterText(By.Id(""),"");
            ObjectRepo.driver.FindElement(By.Id("search")).SendKeys("my video");
            ObjectRepo.driver.FindElement(By.XPath("//button[@id='search-icon-legacy']")).Click();
            ObjectRepo.driver.FindElement(By.XPath("//button[@id='search-icon-legacy']")).Click();

        }
        [TestMethod]
        public void GetDesiredCap()
        {
            AndroidDriver < AndroidElement > driver = DesiredCapability.GetDesiredCapabilities();
            TouchAction t = new TouchAction(driver);
            driver.FindElementByAndroidUIAutomator("text(\"Views\")").Click();
            driver.FindElementsByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"Drag and Drop\"));");
            Thread.Sleep(2000);
            driver.FindElementByAndroidUIAutomator("text(\"Drag and Drop\")").Click();

            Thread.Sleep(2000);

           // t.LongPress(driver.FindElementsByClassName("android.view.View").ElementAt(0)).MoveTo(driver.FindElementsByClassName("android.view.View").ElementAt(1)).Release().Perform();
            driver.PressKeyCode(AndroidKeyCode.Home);
           Console.WriteLine(driver.CurrentActivity);
            Thread.Sleep(5000);


            //t.Tap(driver.FindElementByAndroidUIAutomator("text(\"Expandable Lists\")")).Perform();
            //Thread.Sleep(2000);
            //driver.FindElementByXPath("//android.widget.TextView[@text='1. Custom Adapter']").Click();
            //t.Press(driver.FindElementByAndroidUIAutomator("text(\"People Names\")")).Wait(3000).Release().Perform();

            //Thread.Sleep(2000);
            //driver.FindElementByXPath("//android.widget.TextView[@text='Date Widgets']").Click();
            //Thread.Sleep(2000);
            //driver.FindElementByAndroidUIAutomator("text(\"2. Inline\")").Click();
            //Thread.Sleep(2000);
            //driver.FindElementByXPath("//*[@content-desc='9']").Click();
            //Thread.Sleep(2000);
            //t.Press(driver.FindElementByXPath("//*[@content-desc='15']")).Wait(3000).MoveTo(driver.FindElementByXPath("//*[@content-desc='45']")).Release().Perform();



            ////           Console.WriteLine(driver.FindElementsByAndroidUIAutomator("new UiSelector().clickable(true)").Count());
            //driver.FindElementByXPath("//android.widget.TextView[@text='Preference']").Click();
            //Thread.Sleep(2000);
            //driver.FindElementByXPath("//android.widget.TextView[@content-desc='3. Preference dependencies']").Click();
            //Thread.Sleep(3000);
            //driver.FindElementById("android:id/checkbox").Click();
            //Thread.Sleep(3000);
            //driver.FindElementByXPath("(//android.widget.RelativeLayout)[2]").Click();
            //driver.FindElementByClassName("android.widget.EditText").SendKeys("Hello");
            //driver.FindElementByXPath("//android.widget.Button[@text='OK']").Click();

        }



    }
}
