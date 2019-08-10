using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.LogIn
{
    public class LogInPage
    {
        IWebDriver webDriver;

        public LogInPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public void SetEmailAddress(string email)
        {
            IWebElement emailAddress = webDriver.FindElement(By.Id("email"));
            emailAddress.SendKeys(email);
        }

        public void SetPassword(string password)
        {
            IWebElement passwordAccount = webDriver.FindElement(By.Id("passwd"));
            passwordAccount.SendKeys(password);
        }

        public void ClickSignIn()
        {
            //submitMessage
            IWebElement signinButton = webDriver.FindElement(By.Id("SubmitLogin"));
                                       
            signinButton.Click();
        }
        public void FillAccountData(string email, string password)
        {            
            SetEmailAddress(email);
            SetPassword(password);
            ClickSignIn();
        }
    }
    
}
