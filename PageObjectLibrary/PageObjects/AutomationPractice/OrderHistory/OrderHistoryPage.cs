using OpenQA.Selenium;
using PageObjectLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.OrderHistory
{
    public class OrderHistoryPage : BasePage
    {
        private IWebElement amount = GetDriver().FindElement(By.XPath("//tr[@class='first_item']/td[@class='history_price']/span"));

        public string GetAmount()
        {
            return amount.Text;
        }
    }
}
