using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress
{
    public class ShoppingCartAddressPage : BasePage
    {
        private IWebElement proceedToCheckOutButton = GetDriver().FindElement(By.XPath("//*[@id='center_column']/form/p/button/span"));

        public ShoppingCartShippingPage ProceedToCheckOut()
        {            
            proceedToCheckOutButton.Click();
            ShoppingCartShippingPage shoppingCartShippingPage = new ShoppingCartShippingPage();
            return shoppingCartShippingPage;
        }

    }
}
