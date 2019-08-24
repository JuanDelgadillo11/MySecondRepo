using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ConfirmOrder;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment
{
    public class ShoppingCartPaymentPage : BasePage
    {
        private IWebElement payByBankButton = GetDriver().FindElement(By.ClassName("bankwire"));

        public Confirm PayByBank()
        {
            payByBankButton.Click();
            Confirm confirm = new Confirm();
            return confirm;
        }
    }
}
