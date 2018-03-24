using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
    public class GenericHelper
    {

        public static IWebElement GetElement(By locator)
        {
            IWebElement element = ObjectRepo.driver.FindElement(locator);
            if (element.Displayed)
                return element;
            else
                throw new NoSuchElementException("Element Not found:" + locator.ToString());

        }
        public static string GetElementText(By locator)
        {
            IWebElement element = ObjectRepo.driver.FindElement(locator);
            return element.Text;
        }
        public static void TakeScreenShot(string filename = "Screen")
        {
            Screenshot screen = ObjectRepo.driver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                filename= filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + "jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);

        }
    }
    }