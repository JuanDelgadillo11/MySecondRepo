using OpenQA.Selenium;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping
{
    public class ShoppingCartShippingPage
    {
        IWebDriver webDriver;
        public ShoppingCartShippingPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public void AcceptTerms()
        {
            IWebElement checkbox = webDriver.FindElement(By.Id("cgv"));
            checkbox.Click();
        }

        public ShoppingCartPaymentPage ProceedToCheckOut()
        {
            IWebElement proceedToCheckOutButton = webDriver.FindElement(By.XPath("//*[@id='form']/p/button/span"));
            proceedToCheckOutButton.Click();
            ShoppingCartPaymentPage shoppingCartPaymentPage = new ShoppingCartPaymentPage(webDriver);
            return shoppingCartPaymentPage;
        }
    }
}
