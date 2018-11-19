using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomerException;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
    public class DesiredCapability
    {
        public static RemoteWebDriver GetDesiredCapabilities()
        {
            // ObjectRepo.config = new AppConfigReader();

            if (ObjectRepo.config.GetDevice() == DeviceType.IOS)
            {
                DesiredCapabilities cap1 = new DesiredCapabilities();
                cap1.SetCapability(MobileCapabilityType.PlatformName, MobilePlatform.IOS);
                cap1.SetCapability(MobileCapabilityType.DeviceName, ObjectRepo.config.GetDeviceName());
                cap1.SetCapability(MobileCapabilityType.NewCommandTimeout, "25");
                cap1.SetCapability(MobileCapabilityType.App, "C:\\Users\\fukha\\documents\\visual studio 2017\\Projects\\SeleniumWebdriver\\SeleniumWebdriver\\MobileApp\\ApiDemos-debug.apk");
                IOSDriver<IOSElement> driver1 = new IOSDriver<IOSElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap1);
                return driver1;
            }

            else
            { 
            //    if (ObjectRepo.config.GetDevice() == DeviceType.Android)
            
                DesiredCapabilities cap2 = new DesiredCapabilities();
                cap2.SetCapability(MobileCapabilityType.PlatformName, MobilePlatform.IOS);
                cap2.SetCapability(MobileCapabilityType.DeviceName, ObjectRepo.config.GetDeviceName());
                cap2.SetCapability(MobileCapabilityType.NewCommandTimeout, "25");
                cap2.SetCapability(MobileCapabilityType.App, "C:\\Users\\fukha\\documents\\visual studio 2017\\Projects\\SeleniumWebdriver\\SeleniumWebdriver\\MobileApp\\ApiDemos-debug.apk");
                AndroidDriver<AndroidElement> driver2 = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap2);
                return driver2;
            }
        }

        }


    }
            

        }
    


//Uri uri1 = new Uri(@"C:\\Users\\fukha\\documents\\visual studio 2017\\Projects\\SeleniumWebdriver\\SeleniumWebdriver\\MobileApp\\ApiDemos-debug.apk");
//Uri uri2 = new Uri(@"ApiDemos-debug.apk");
//string relativePath = uri2.MakeRelativeUri(uri1).ToString();

            //DesiredCapabilities cap = new DesiredCapabilities();
            //cap.SetCapability(MobileCapabilityType.PlatformName,MobilePlatform.Android);
            //cap.SetCapability(MobileCapabilityType.DeviceName,"Android device");
            //cap.SetCapability(MobileCapabilityType.NewCommandTimeout, "25");
            //cap.SetCapability(AndroidMobileCapabilityType.AppPackage,"net.one97.paytm");
            //cap.SetCapability(AndroidMobileCapabilityType.AppActivity, "net.one97.paytm.AJRJarvisSplash");



            //AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            
 