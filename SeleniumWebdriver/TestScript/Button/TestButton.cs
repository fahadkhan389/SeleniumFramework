using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.CheckBox
{
    [TestClass]
    class TestButton
    {
        [TestMethod]
        public void ClickButton()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            ButtonHelper.ClickButton(By.Id(""));
            Console.WriteLine(ButtonHelper.IsButtonEnabled(By.Id("")));
                Console.WriteLine(ButtonHelper.GetButtontext(By.Id("")));
        }
    }
}
