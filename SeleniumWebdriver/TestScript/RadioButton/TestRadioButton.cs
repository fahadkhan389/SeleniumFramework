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
    class TestRadioButton
    {
        [TestMethod]
        public void ClickRadioButton()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            RadioBbuttonHelper.ClickRadioButton(By.Id(""));
            Console.WriteLine(RadioBbuttonHelper.IsRadioButtonSelected(By.Id("")));
        }
    }
}
