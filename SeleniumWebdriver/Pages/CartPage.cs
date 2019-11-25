using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Pages
{
    class CartPage : BaseClass
    {
        public CartPage(IWebDriver driver) : base(ObjectRepo.driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//form[@name='form']/table/tbody/tr[1]/td[1]")]
        public IWebElement CartItemFunnyCowXpath { get; set; }

        String ExpectedFunnyCowTxt = "Funny Cow";

        [FindsBy(How = How.XPath, Using = "//form[@name='form']/table/tbody/tr[2]/td[1]")]
        public IWebElement CartItemFluffyBunnyXpath { get; set; }


        String ExpectedFluffyBunnyTxt = "Fluffy Bunny";

        
        public void VerifyQuantity()
        {
            string ActualFunnyCowTxt = GenericHelper.GetElementText(CartItemFunnyCowXpath);
            Assert.IsTrue(ActualFunnyCowTxt.Equals(ExpectedFunnyCowTxt));

            string ActualFluffyBunnyTxt = GenericHelper.GetElementText(CartItemFluffyBunnyXpath);
            Assert.IsTrue(ActualFluffyBunnyTxt.Equals(ExpectedFluffyBunnyTxt));

        }


    }
}
