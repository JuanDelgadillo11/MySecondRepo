using FirstTestSolution.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjectLibrary.Accounts;
using PageObjectLibrary.PageObjects.AutomationPractice.ConfirmOrder;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;
using PageObjectLibrary.PageObjects.AutomationPractice.OrderHistory;
using PageObjectLibrary.PageObjects.AutomationPractice.OrderSummary;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary;
using PageObjectLibrary.PageObjects.AutomationPractice.Women;
using PageObjectLibrary.Steps.AutomationPractice.Purchase;
using System;

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

        [TestMethod, TestCategory("Task2")]

        public void Purchace()
        {
            LogInPage loginPage = navigationSteps.NavigateToLogIn();
            loginPage.FillAccountData("juan.pablo.delgadillo.peredo@gmail.com", "Control123");

            DressesPage dressesPage = navigationSteps.NavigateToDressesPage();
            PurchaseADress purchaseADress = new PurchaseADress();
            int amountToBuy = 2;
            purchaseADress.Buy(amountToBuy);

            Assert.AreEqual(purchaseADress.TotalOrder,purchaseADress.TotalPaid);
        }

        [TestMethod, TestCategory("Task3")]

        public void PurchaceAWomenDress()
        {
            LogInPage loginPage = navigationSteps.NavigateToLogIn();
            loginPage.FillAccountData(UserTest.GetEmail(), UserTest.GetPassword());
            
            WomenPage womenPage = navigationSteps.NavigateToWomenPage();
            PurchaseADress purchaseADress = new PurchaseADress();
            int amountToBuy = 2;
            purchaseADress.Buy(amountToBuy);

            navigationSteps.NavigateToViewCustomerAccount();
            OrderHistoryPage order= navigationSteps.NavigateToOrderHistory();

            Assert.AreEqual(purchaseADress.TotalOrder, order.GetAmount());
        }
    }
}
