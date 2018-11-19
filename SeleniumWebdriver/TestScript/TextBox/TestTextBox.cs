using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            TextBoxHelper.EnterText(By.Id("lst-ib"),ObjectRepo.config.GetUsername());
            TextBoxHelper.ClearText(By.Id("lst-ib"));
            TextBoxHelper.EnterText(By.Id("lst-ib"), ObjectRepo.config.GetPassword());

        }

    }
}
