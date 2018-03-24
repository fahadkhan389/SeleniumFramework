using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement element;

        public static void EnterText(By locator,string text)
        {
            element=GenericHelper.GetElement(locator);
            element.SendKeys(text);

        }
        public static void ClearText(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Clear();

        }



    }

}
