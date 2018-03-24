using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.ComboBox
{
    [TestClass]
   public class TextComboBox
    {

        public void SelectComboBox()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            ComboBoxHelper.SelectElement(By.Id(""),2);
            ComboBoxHelper.SelectElement(By.Id(""),"visibletext");
            foreach (string str in ComboBoxHelper.GetAllitems(By.Id("")))
            {
                Console.WriteLine(str);

            }
        }
    }
}
