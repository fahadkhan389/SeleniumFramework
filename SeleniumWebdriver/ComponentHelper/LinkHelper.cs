using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement element;

        public static void ClickLink(By locator)
        {
            element=GenericHelper.GetElement(locator);
            element.Click();

        }




    }

}
