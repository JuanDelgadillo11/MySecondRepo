using OpenQA.Selenium;
using PageObjectLibrary.AutomationPractice.ContactUs;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.AutomationPractice.Menu
{
    public class MenuPage
    {
        IWebDriver webDriver;

        public MenuPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public ContactUsPage ClickContactUs()
        {
            IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
            contactUsButton.Click();
            ContactUsPage contactUsPage = new ContactUsPage(webDriver);
            return contactUsPage;
        }

        public LogInPage ClickLogin()
        {
            IWebElement loginButton = webDriver.FindElement(By.ClassName("login"));
            loginButton.Click();
            LogInPage loginPage = new LogInPage(webDriver);
            return loginPage;
        }

    }
}
