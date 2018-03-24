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
public    class BrowserHelper
    {
        public static void MaximizeWindow()
        {
            ObjectRepo.driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepo.driver.Navigate().Back();
        }

        public static void GoForward()
        {
            ObjectRepo.driver.Navigate().Forward();
        }
        public static void Refresh()
        {
            ObjectRepo.driver.Navigate().Refresh();
        }
        public static void SwitchWindow(int index=0)
        {
            ReadOnlyCollection<string> windows = ObjectRepo.driver.WindowHandles;
            if (windows.Count < index)
            {
                throw new NoSuchWindowException("invalid browser window" + index);
            }
            ObjectRepo.driver.SwitchTo().Window(windows[index]);
            MaximizeWindow();
        }
        public static void SwitchFrame(By locator)
        {
            ObjectRepo.driver.SwitchTo().Frame(ObjectRepo.driver.FindElement(locator));
            }
    }
}
