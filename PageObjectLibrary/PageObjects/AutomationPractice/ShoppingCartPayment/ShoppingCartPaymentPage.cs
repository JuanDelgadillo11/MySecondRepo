using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment
{
    public class ShoppingCartPaymentPage
    {
        IWebDriver webDriver;
        public ShoppingCartPaymentPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public void PayByBank()
        {
            IWebElement payByBankButton = webDriver.FindElement(By.ClassName("bankwire"));
            payByBankButton.Click();
        }
                
        public void ConfirmOrder()
        {
            IWebElement confirmOrder = webDriver.FindElement(By.XPath("//*[@id='cart_navigation']/button/span"));
            confirmOrder.Click();
        }

        public string GetActualAmount()
        {
            IWebElement confirmationLabel = webDriver.FindElement(By.XPath("//*[@id='center_column']/div/span/strong"));
            string message = confirmationLabel.Text;
            return message;
        }

    }
}
