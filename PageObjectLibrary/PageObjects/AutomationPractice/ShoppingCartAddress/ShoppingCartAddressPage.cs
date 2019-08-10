using OpenQA.Selenium;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress
{
    public class ShoppingCartAddressPage
    {
        IWebDriver webDriver;
        public ShoppingCartAddressPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public ShoppingCartShippingPage ProceedToCheckOut()
        {
            IWebElement proceedToCheckOutButton = webDriver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span"));
            proceedToCheckOutButton.Click();
            ShoppingCartShippingPage shoppingCartShippingPage = new ShoppingCartShippingPage(webDriver);
            return shoppingCartShippingPage;
        }

    }
}
