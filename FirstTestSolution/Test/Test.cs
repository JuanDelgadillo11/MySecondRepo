using FirstTestSolution.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjectLibrary.PageObjects.AutomationPractice.ConfirmOrder;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;
using PageObjectLibrary.PageObjects.AutomationPractice.OrderSummary;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary;

namespace FirstTestSolution
{
    [TestClass]
    public class Test:Hook
    {
        [TestMethod, TestCategory("ContactUs Valid data")]
        public void ContactUsFormIsSentCorrectly()
        {           
            //LogInPage loginPage = navigationSteps.NavigateToLogIn();
            //loginPage.FillAccountData("juan.pablo.delgadillo.peredo@gmail.com", "Control123");
            //ContactUsPage contactUsPage = navigationSteps.NavigateToContactUs();
            ////contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText,"Customer service", "juan.pablo.delgadillo.peredo@gmail.com", "1234", @"C:\test.txt", "Hola, compraste esto");
            //string actualMessage= contactUsPage.GetConfirmationMessage();
            //string expectedMessage = "Your message has been successfully sent to our team.";
            //Assert.AreEqual(expectedMessage, actualMessage);           

        }

        [TestMethod]
        public void Purchace()
        {
            LogInPage loginPage = navigationSteps.NavigateToLogIn();
            loginPage.FillAccountData("juan.pablo.delgadillo.peredo@gmail.com", "Control123");
            DressesPage dressesPage = navigationSteps.NavigateToDresses();
            dressesPage.AddToCart();

            ShoppingCartSummaryPage shoppingCartSummaryPage =  dressesPage.ProceedToCheckOut();
            
            shoppingCartSummaryPage.AddQty(2);
            string total = shoppingCartSummaryPage.GetTotal();
            
            ShoppingCartAddressPage shoppingCartAddressPage = shoppingCartSummaryPage.ProceedToCheckOut();

            ShoppingCartShippingPage shoppingCartShippingPage = shoppingCartAddressPage.ProceedToCheckOut();
            shoppingCartShippingPage.AcceptTerms();           

            ShoppingCartPaymentPage shoppingCartPaymentPage = shoppingCartShippingPage.ProceedToCheckOut();
            Confirm confirm= shoppingCartPaymentPage.PayByBank();
          
            Order orderToBuy= confirm.ConfirmOrderToBuy();
            
            string actualAmount = orderToBuy.GetAmount();
            Assert.AreEqual(total, actualAmount);
        }
    }
}
