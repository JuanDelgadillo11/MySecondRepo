using OpenQA.Selenium;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Dresses
{
    public class DressesPage
    {
        IWebDriver webDriver;

        public DressesPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public void AddToCart()
        {
            IList<IWebElement> products = webDriver.FindElements(By.XPath("//div[@class='button-container']/a[@class='button ajax_add_to_cart_button btn btn-default']/span"));
            IWebElement productCell = products[0];
            productCell.Click();
        }

        public ShoppingCartSummaryPage ProceedToCheckOut()
        {            
            IWebElement proceedToCheckOutButton = webDriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span"));
            proceedToCheckOutButton.Click();
            ShoppingCartSummaryPage shoppingCartSummaryPage = new ShoppingCartSummaryPage(webDriver);
            return shoppingCartSummaryPage;
        }

    }
}
