using OpenQA.Selenium;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary
{
    public class ShoppingCartSummaryPage
    {
        IWebDriver webDriver;

        public ShoppingCartSummaryPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public string GetUnitPrice()
        {
            IWebElement unitPrice = webDriver.FindElement(By.XPath("//p[@class='alert alert-success']"));
            string message = unitPrice.Text;
            return message;
        }

        public string GetQty()
        {
            IWebElement qty = webDriver.FindElement(By.XPath("//p[@class='alert alert-success']"));
            string message = qty.Text;
            return message;
        }

        public string GetTotal()
        {
            IWebElement total = webDriver.FindElement(By.Id("total_price"));
            string message = total.Text;
            return message;
        }

        public ShoppingCartAddressPage ProceedToCheckOut()
        {
            IWebElement proceedToCheckOutButton = webDriver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span"));
            proceedToCheckOutButton.Click();
            ShoppingCartAddressPage shoppingCartAddressPage = new ShoppingCartAddressPage(webDriver);
            return shoppingCartAddressPage;
        }
    }
}
