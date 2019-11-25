using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.Pages
{
    class HomePage : BaseClass
    {
        public HomePage(IWebDriver driver) : base(ObjectRepo.driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//a[@href='#/contact']")]
        public IWebElement ContactLinkXpath { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[@href='#/shop']")]
        public IWebElement ShopLinkXpath { get; set; }

        public ContactPage ClickContact()
        {
            LinkHelper.ClickLink(ContactLinkXpath);
            return new ContactPage(ObjectRepo.driver);
        }

        public ShopPage ClickShop()
        {
            LinkHelper.ClickLink(ShopLinkXpath);
            return new ShopPage(ObjectRepo.driver);
        }

    }
}