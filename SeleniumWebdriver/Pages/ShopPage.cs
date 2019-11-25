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
    class ShopPage : BaseClass
    {
        public ShopPage(IWebDriver driver) : base(ObjectRepo.driver)
        {
            
        }
        [FindsBy(How = How.XPath, Using = "//a[@href='#/cart']")]
        public IWebElement CartlinkXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@class='ng-scope']/div[@class='container-fluid']//ul/li[6]//a")]
        public IWebElement BuybtnFunnyCowXpath { get; set; }

        [FindsBy(How = How.XPath, Using = "//body[@class='ng-scope']/div[@class='container-fluid']//ul/li[4]//a")]
        public IWebElement BuybtnFluffyBunnyXpath { get; set; }





        public void ClickFunnyCow()
        {
            ButtonHelper.ClickButton(BuybtnFunnyCowXpath);

        }


        public void ClickFluffyBunny()
        {
            ButtonHelper.ClickButton(BuybtnFluffyBunnyXpath);

        }


        public CartPage ClickCart()
        {
            LinkHelper.ClickLink(CartlinkXpath);
            return new CartPage(ObjectRepo.driver);
        }

    }
}