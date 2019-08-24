using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ProductsMenu
{
    public class ProductsMenuPage : BasePage
    {
        private IWebElement dressesButton = GetDriver().FindElement(By.ClassName("sf-with-ul"));

        public DressesPage ClickDresses()
        {            
            dressesButton.Click();
            DressesPage dressesPage = new DressesPage();
            return dressesPage;
        }
    }
}
