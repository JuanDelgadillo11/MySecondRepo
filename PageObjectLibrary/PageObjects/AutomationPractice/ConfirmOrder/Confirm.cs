using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.OrderSummary;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ConfirmOrder
{
    public class Confirm : BasePage
    {
        private IWebElement confirmOrder = GetDriver().FindElement(By.XPath("//button[@class='button btn btn-default button-medium']"));
           
        public Order ConfirmOrderToBuy()
        {
            confirmOrder.Click();
            Order orderToBuy = new Order();
            return orderToBuy;
        }
    }
}
