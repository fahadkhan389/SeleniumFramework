using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.Hyperlink
{
    [TestClass]
   public class TestHyperlink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            LinkHelper.ClickLink(By.XPath("//div[@id='Eyebrow']/descendant::a[@href='https://mail.yahoo.com/?.intl=au&.lang=en-AU&.partner=none&.src=fp']"));
            GenericHelper.TakeScreenShot();
        }

    }
}
