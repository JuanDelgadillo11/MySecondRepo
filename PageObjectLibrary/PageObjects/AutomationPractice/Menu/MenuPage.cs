using OpenQA.Selenium;
using PageObjectLibrary.AutomationPractice.ContactUs;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;

namespace PageObjectLibrary.AutomationPractice.Menu
{
    public class MenuPage: BasePage
    {
        private IWebElement contactUsButton = GetDriver().FindElement(By.Id("contact-link"));
        private IWebElement loginButton = GetDriver().FindElement(By.ClassName("login"));

        public ContactUsPage ClickContactUs()
        {            
            contactUsButton.Click();
            ContactUsPage contactUsPage = new ContactUsPage();
            return contactUsPage;
        }

        public LogInPage ClickLogin()
        {            
            loginButton.Click();
            LogInPage loginPage = new LogInPage();
            return loginPage;
        }

    }
}
