using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.Women;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ProductsMenu
{
    public class ProductsMenuPage : BasePage
    {
        private IWebElement dressesButton = GetDriver().FindElement(By.ClassName("sf-with-ul"));
        private IWebElement womenButton = GetDriver().FindElement(By.ClassName("sf-with-ul"));

        public DressesPage ClickDresses()
        {            
            dressesButton.Click();
            DressesPage dressesPage = new DressesPage();
            return dressesPage;
        }

        public WomenPage ClickWomen()
        {
            womenButton.Click();
            WomenPage womenPage = new WomenPage();
            return womenPage;
        }
    }
}
