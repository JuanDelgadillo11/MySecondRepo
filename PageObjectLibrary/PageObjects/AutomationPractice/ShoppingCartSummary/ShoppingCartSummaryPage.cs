using OpenQA.Selenium;
using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress;

namespace PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary
{
    public class ShoppingCartSummaryPage : BasePage
    {        
        private IWebElement unitPrice = GetDriver().FindElement(By.XPath("//span[@class='price']/span[@class='price']"));       
        private IWebElement qty = GetDriver().FindElement(By.XPath("//input[@class='cart_quantity_input form-control grey']"));
        private IWebElement total = GetDriver().FindElement(By.Id("total_price"));        
        private IWebElement addElement = GetDriver().FindElement(By.XPath("//a[@class='cart_quantity_up btn btn-default button-plus']"));
        private IWebElement proceedToCheckOutButton = GetDriver().FindElement(By.XPath("//a[@class='button btn btn-default standard-checkout button-medium']"));        

        public string GetUnitPrice()
        {            
            string message = unitPrice.Text;
            return message;
        }

        public string GetQty()
        {            
            string message = qty.Text;
            return message;
        }

        public string GetTotal()
        {            
            string message = total.Text;
            return message;
        }

        public void AddQty(int ammount)
        {            
            for (int i = 0; i < ammount; i++)
            {
                addElement.Click();
            }
            
        }

        public ShoppingCartAddressPage ProceedToCheckOut()
        {            
            proceedToCheckOutButton.Click();
            ShoppingCartAddressPage shoppingCartAddressPage = new ShoppingCartAddressPage();
            return shoppingCartAddressPage;
        }
    }
}
