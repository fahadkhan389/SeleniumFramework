using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.Pages;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            HomePage hpage = new HomePage(ObjectRepo.driver);
            ContactPage cpage=hpage.ClickContact();
            cpage.SubmitAndValidateError();
            cpage.EnterMandatoryFieldsAndValidateNoError();
        }

        [TestMethod]
        public void TestCase2()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            HomePage hpage = new HomePage(ObjectRepo.driver);
            ContactPage cpage = hpage.ClickContact();
            cpage.EnterMandatoryFieldsAndSubmit();
        }

        [TestMethod]
        public void TestCase3()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            HomePage hpage = new HomePage(ObjectRepo.driver);
            ContactPage cpage = hpage.ClickContact();
            cpage.SubmitInvalidDataAndValidateError();

        }

        [TestMethod]
        public void TestCase4()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            HomePage hpage = new HomePage(ObjectRepo.driver);
            ShopPage spage = hpage.ClickShop();
            spage.ClickFunnyCow();
            spage.ClickFunnyCow();
            spage.ClickFluffyBunny();
            CartPage cartpage=  spage.ClickCart();
            cartpage.VerifyQuantity();
        }

    }
}
