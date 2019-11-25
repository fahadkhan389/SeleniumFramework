using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
    public class ButtonHelper
    {
        private static IWebElement element;

        
        public static void ClickButton(IWebElement element)
        {
            element.Click();

        }

        public static bool IsButtonEnabled(By locator)
        {
            element = GenericHelper.GetElement(locator);
            return element.Enabled;
                
                    }

        public static string GetButtontext(By locator)
        {
            element = GenericHelper.GetElement(locator);
            if (element.GetAttribute("value") == null)
                return string.Empty;
            return element.GetAttribute("value");
        }
        

    }

}
