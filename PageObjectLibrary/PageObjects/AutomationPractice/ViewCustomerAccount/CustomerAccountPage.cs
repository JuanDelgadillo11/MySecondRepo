using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.OrderHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ViewCustomerAccount
{
    public class CustomerAccountPage : BasePage
    {
        private IWebElement customerAccount = GetDriver().FindElement(By.XPath("//a[@class='account']"));
        private IWebElement orderHistoryAndDetails = GetDriver().FindElement(By.XPath("//a[@href='http://automationpractice.com/index.php?controller=history']"));

        public void Click()
        {
            customerAccount.Click();
        }

        public OrderHistoryPage ClickOrderHistoryAndDetails()
        {
            orderHistoryAndDetails.Click();
            OrderHistoryPage orderHistory = new OrderHistoryPage();
            return orderHistory;
        }

    }
}
