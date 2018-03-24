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
    class TestCheckBox
    {
        [TestMethod]
        public void ClickCheckBox()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            CheckBoxHelper.ClickCheckBox(By.Id(""));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("")));
        }
    }
}
