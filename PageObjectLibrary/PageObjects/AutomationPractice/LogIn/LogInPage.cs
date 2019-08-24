using OpenQA.Selenium;
using PageObjectLibrary.Base;

namespace PageObjectLibrary.PageObjects.AutomationPractice.LogIn
{
    public class LogInPage : BasePage
    {
        private IWebElement emailAddress = GetDriver().FindElement(By.Id("email"));
        private IWebElement passwordAccount = GetDriver().FindElement(By.Id("passwd"));
        private IWebElement signinButton = GetDriver().FindElement(By.Id("SubmitLogin"));

        public void SetEmailAddress(string email)
        {            
            emailAddress.SendKeys(email);
        }

        public void SetPassword(string password)
        {            
            passwordAccount.SendKeys(password);
        }

        public void ClickSignIn()
        {                                      
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
