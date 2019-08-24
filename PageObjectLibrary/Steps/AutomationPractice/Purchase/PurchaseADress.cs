using PageObjectLibrary.Base;
using PageObjectLibrary.PageObjects.AutomationPractice.ConfirmOrder;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.OrderSummary;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.Steps.AutomationPractice.Purchase
{
    public class PurchaseADress : BaseStep
    {
        
        public void Buy(int amountToBuy)
        {
           
            DressesPage dressesPage = new DressesPage();
            dressesPage.AddToCart();

            ShoppingCartSummaryPage shoppingCartSummaryPage = dressesPage.ProceedToCheckOut();

            shoppingCartSummaryPage.AddQty(amountToBuy);
            TotalOrder = shoppingCartSummaryPage.GetTotal();
            
            ShoppingCartAddressPage shoppingCartAddressPage = shoppingCartSummaryPage.ProceedToCheckOut();

            ShoppingCartShippingPage shoppingCartShippingPage = shoppingCartAddressPage.ProceedToCheckOut();
            shoppingCartShippingPage.AcceptTerms();

            ShoppingCartPaymentPage shoppingCartPaymentPage = shoppingCartShippingPage.ProceedToCheckOut();
            Confirm confirm = shoppingCartPaymentPage.PayByBank();

            Order orderToBuy = confirm.ConfirmOrderToBuy();
            TotalPaid= orderToBuy.GetAmount();          

        }

        public string TotalOrder { get; set; }
        public string TotalPaid { get; set; }

    }
}
