using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Pages
{
    class BaseClass
    {
        [Obsolete]
        public BaseClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
    }
}