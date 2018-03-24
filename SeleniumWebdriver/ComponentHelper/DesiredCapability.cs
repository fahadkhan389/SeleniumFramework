using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;

namespace SeleniumWebdriver.ComponentHelper
{
    public class DesiredCapability
    {
        public static void GetDesiredCapabilities()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability(MobileCapabilityType.DeviceName, "Demo");
            cap.SetCapability(MobileCapabilityType.App, "C:\\Users\fukha\\documents\visual studio 2017\\Projects\\SeleniumWebdriver\\SeleniumWebdriver\\MobileApp\\ApiDemos-debug.apk");
            AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"),cap);
        }

    }
}
