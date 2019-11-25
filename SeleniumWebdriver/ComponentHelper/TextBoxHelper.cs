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
        public static void EnterText(IWebElement element, string text)
        {
            element.SendKeys(text);

        }
        public static void ClearText(IWebElement element)
        {
            element.Clear();

        }



    }

}
