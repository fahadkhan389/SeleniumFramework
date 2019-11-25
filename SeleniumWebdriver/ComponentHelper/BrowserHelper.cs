using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
    public class BrowserHelper
    {
        public static void MaximizeWindow()
        {
            ObjectRepo.driver.Manage().Window.Maximize();
        }

    }
}