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
    class ContactPage : BaseClass
    {
        public ContactPage(IWebDriver driver) : base(ObjectRepo.driver)
        {

        }

        
        [FindsBy(How = How.Id, Using = "forename-err")]
        public IWebElement ForenameId { get; set; }

        String ExpectedFornameErrorMsg = "Forename is required";


        [FindsBy(How = How.Id, Using = "email-err")]
        public IWebElement EmailId { get; set; }

        String ExpectedEmailErrorMsg = "Email is required";
        String ExpectedInvalidEmailErrorMsg = "Please enter a valid email";

        [FindsBy(How = How.Id, Using = "message-err")]
        public IWebElement MessageId { get; set; }

        String ExpectedErrorMsg = "Message is required";


        [FindsBy(How = How.Id, Using = "header-message")]
        public IWebElement HeaderMessageId { get; set; }

        String ExpectedHeaderErrorMsg = "We welcome your feedback - but we won't get it unless you complete the form correctly.";
        

        [FindsBy(How = How.XPath, Using = "//a[text()='Submit']")]
        public IWebElement SubmitBtnXpath { get; set; }


        [FindsBy(How = How.Id, Using = "forename")]
        public IWebElement ForeNameTxtboxId { get; set; }

        
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTxtboxId { get; set; }

        
        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement MessageTxtboxId { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-success']")]
        public IWebElement FeedbackConfirmationXpath { get; set; }

        


        public void SubmitAndValidateError()
        {
            ButtonHelper.ClickButton(SubmitBtnXpath);
            string ActualForenameMsg= GenericHelper.GetElementText(ForenameId);
            Assert.IsTrue(ActualForenameMsg.Equals(ExpectedFornameErrorMsg));

            string ActualEmailMsg = GenericHelper.GetElementText(EmailId);
            Assert.IsTrue(ActualEmailMsg.Equals(ExpectedEmailErrorMsg));

            string ActualErrorMessage = GenericHelper.GetElementText(MessageId);
            Assert.IsTrue(ActualErrorMessage.Equals(ExpectedErrorMsg));

            string ActualHeaderErrorMsg = GenericHelper.GetElementText(HeaderMessageId);
            Assert.IsTrue(ActualHeaderErrorMsg.Equals(ExpectedHeaderErrorMsg));


        }

        public void SubmitInvalidDataAndValidateError()
        {
            TextBoxHelper.EnterText(ForeNameTxtboxId, "Steve");
            TextBoxHelper.EnterText(EmailTxtboxId, "abc");
            TextBoxHelper.EnterText(MessageTxtboxId, "This is testing");
            string ActualEmailMsg = GenericHelper.GetElementText(EmailId);
            Assert.IsTrue(ActualEmailMsg.Equals(ExpectedInvalidEmailErrorMsg));
            string ActualHeaderErrorMsg = GenericHelper.GetElementText(HeaderMessageId);
            Assert.IsTrue(ActualHeaderErrorMsg.Equals(ExpectedHeaderErrorMsg));


        }


        public void EnterMandatoryFieldsAndValidateNoError()
        {
            TextBoxHelper.EnterText(ForeNameTxtboxId, "Steve");
            TextBoxHelper.EnterText(EmailTxtboxId, "abc@hotmail.com");
            TextBoxHelper.EnterText(MessageTxtboxId, "This is testing");
            Assert.IsFalse(GenericHelper.ElementExists(ForenameId));
            Assert.IsFalse(GenericHelper.ElementExists(EmailId));
            Assert.IsFalse(GenericHelper.ElementExists(MessageId));
            string ActualHeaderErrorMsg = GenericHelper.GetElementText(HeaderMessageId);
            Assert.IsFalse(ActualHeaderErrorMsg.Equals(ExpectedHeaderErrorMsg));

        }


        public void EnterMandatoryFieldsAndSubmit()
        {
            TextBoxHelper.EnterText(ForeNameTxtboxId, "Steve");
            TextBoxHelper.EnterText(EmailTxtboxId, "abc@hotmail.com");
            TextBoxHelper.EnterText(MessageTxtboxId, "This is testing");
            ButtonHelper.ClickButton(SubmitBtnXpath);
            Assert.IsTrue(GenericHelper.ElementExists(FeedbackConfirmationXpath));
            
        }



    }
}