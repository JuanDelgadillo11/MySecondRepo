using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping
{
    public class ShoppingCartShippingPage : BasePage
    {
        private IWebElement checkbox = GetDriver().FindElement(By.Id("cgv"));
        private IWebElement proceedToCheckOutButton = GetDriver().FindElement(By.XPath("//*[@id='form']/p/button/span"));

        public void AcceptTerms()
        {            
            checkbox.Click();
        }

        public ShoppingCartPaymentPage ProceedToCheckOut()
        {            
            proceedToCheckOutButton.Click();
            ShoppingCartPaymentPage shoppingCartPaymentPage = new ShoppingCartPaymentPage();
            return shoppingCartPaymentPage;
        }
    }
}
