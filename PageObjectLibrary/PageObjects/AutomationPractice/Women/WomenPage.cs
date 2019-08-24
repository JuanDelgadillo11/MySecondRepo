using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.Women
{
    public class WomenPage : BasePage
    {
        private IList<IWebElement> products = GetDriver().FindElements(By.XPath("//div[@class='button-container']/a[@class='button ajax_add_to_cart_button btn btn-default']/span"));
        private IWebElement proceedToCheckOutButton = GetDriver().FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span"));

        public void AddToCart()
        {
            IWebElement productCell = products[0];
            productCell.Click();
        }

        public ShoppingCartSummaryPage ProceedToCheckOut()
        {
            proceedToCheckOutButton.Click();
            ShoppingCartSummaryPage shoppingCartSummaryPage = new ShoppingCartSummaryPage();
            return shoppingCartSummaryPage;
        }

    }
}
