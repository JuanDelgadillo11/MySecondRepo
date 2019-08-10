using OpenQA.Selenium;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ProductsMenu
{
    public class ProductsMenuPage
    {
        IWebDriver webDriver;

        public ProductsMenuPage(IWebDriver web)
        {
            this.webDriver = web;
        }

        public DressesPage ClickDresses()
        {
            IWebElement dressesButton = webDriver.FindElement(By.ClassName("sf-with-ul"));
            dressesButton.Click();
            DressesPage dressesPage = new DressesPage(webDriver);
            return dressesPage;
        }
    }
}
