using OpenQA.Selenium;
using PageObjectLibrary.AutomationPractice.ContactUs;
using PageObjectLibrary.AutomationPractice.Menu;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;
using PageObjectLibrary.PageObjects.AutomationPractice.ProductsMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.Steps.AutomationPractice.Navigation
{
    public class NavigationSteps
    {
        IWebDriver webDriver;

        public NavigationSteps(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public ContactUsPage NavigateToContactUs()
        {    
            MenuPage menuPage = new MenuPage(webDriver);
            ContactUsPage contactUsPage = menuPage.ClickContactUs();
            return contactUsPage;

        }

        public LogInPage NavigateToLogIn()
        {
            MenuPage menuPage = new MenuPage(webDriver);
            LogInPage loginPage = menuPage.ClickLogin();
            return loginPage;

        }

        public DressesPage NavigateToDresses()
        {
            ProductsMenuPage productsMenuPage = new ProductsMenuPage(webDriver);
            DressesPage dressessPage = productsMenuPage.ClickDresses();
            return dressessPage;

        }

    }
}
