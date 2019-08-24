using PageObjectLibrary.AutomationPractice.ContactUs;
using PageObjectLibrary.AutomationPractice.Menu;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;
using PageObjectLibrary.PageObjects.AutomationPractice.ProductsMenu;

namespace PageObjectLibrary.Steps.AutomationPractice.Navigation
{
    public class NavigationSteps :BaseStep
    {
        public NavigationSteps()
        {
            NavigateToInitialSite();
        }

        public ContactUsPage NavigateToContactUs()
        {    
            MenuPage menuPage = new MenuPage();
            ContactUsPage contactUsPage = menuPage.ClickContactUs();
            return contactUsPage;
        }

        public LogInPage NavigateToLogIn()
        {
            MenuPage menuPage = new MenuPage();
            LogInPage loginPage = menuPage.ClickLogin();
            return loginPage;
        }

        public DressesPage NavigateToDresses()
        {
            ProductsMenuPage productsMenuPage = new ProductsMenuPage();
            DressesPage dressessPage = productsMenuPage.ClickDresses();
            return dressessPage;
        }
    }
}
