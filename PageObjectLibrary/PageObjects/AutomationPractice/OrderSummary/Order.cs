using OpenQA.Selenium;
using PageObjectLibrary.Base;

namespace PageObjectLibrary.PageObjects.AutomationPractice.OrderSummary
{
    public class Order : BasePage
    {
        private IWebElement amount = GetDriver().FindElement(By.XPath("//span[@class='price']/strong"));

        public string GetAmount()
        {
            return amount.Text;
        }
    }
}
