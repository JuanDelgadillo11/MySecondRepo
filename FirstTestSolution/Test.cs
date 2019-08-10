using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectLibrary.AutomationPractice.ContactUs;
using PageObjectLibrary.AutomationPractice.Menu;
using PageObjectLibrary.PageObjects.AutomationPractice.Dresses;
using PageObjectLibrary.PageObjects.AutomationPractice.LogIn;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartAddress;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartPayment;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartShipping;
using PageObjectLibrary.PageObjects.AutomationPractice.ShoppingCartSummary;
using PageObjectLibrary.Steps.AutomationPractice.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestSolution
{
    //decorator para el unit test (en esta clase existen test)
    [TestClass]
    public class Test
    {

        IWebDriver webDriver;
        NavigationSteps navigationSteps;
        
        public Test()
        {
            //moviendo al setup
            //webDriver = new ChromeDriver(@"C:\SeleniumWebDrivers");
            //navigationSteps = new NavigationSteps(webDriver);
        }

        [TestMethod, TestCategory("ContactUs Valid data")]
        public void ContactUsFormIsSentCorrectly()
        {
            ContactUsPage contactUsPage = navigationSteps.NavigateToContactUs();
            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText,"Customer service", "juan.pablo.delgadillo.peredo@gmail.com", "1234", @"C:\test.txt", "Hola, compraste esto");

            string actualMessage= contactUsPage.GetConfirmationMessage();
            string expectedMessage = "Your message has been successfully sent to our team.";

            Assert.AreEqual(expectedMessage, actualMessage);

        }

        [TestMethod]
        public void Purchace()
        {
            LogInPage loginPage = navigationSteps.NavigateToLogIn();
            loginPage.FillAccountData("juan.pablo.delgadillo.peredo@gmail.com","Control123");

            DressesPage dressesPage = navigationSteps.NavigateToDresses();
            dressesPage.AddToCart();

            ShoppingCartSummaryPage shoppingCartSummaryPage =  dressesPage.ProceedToCheckOut();

            string total = shoppingCartSummaryPage.GetTotal();

            ShoppingCartAddressPage shoppingCartAddressPage = shoppingCartSummaryPage.ProceedToCheckOut();

            ShoppingCartShippingPage shoppingCartShippingPage = shoppingCartAddressPage.ProceedToCheckOut();
            shoppingCartShippingPage.AcceptTerms();

            ShoppingCartPaymentPage shoppingCartPaymentPage = shoppingCartShippingPage.ProceedToCheckOut();
            shoppingCartPaymentPage.PayByBank();
            shoppingCartPaymentPage.ConfirmOrder();

            string actualAmount = shoppingCartPaymentPage.GetActualAmount();
            Assert.AreEqual(total, actualAmount);

        }
        [TestInitialize]

        public void Setup()
        {
            webDriver = new ChromeDriver(@"C:\SeleniumWebDrivers");
            //adding wait implicit
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //tiempo que espera antes de que se cargue la pagna completamente
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);

            navigationSteps = new NavigationSteps(webDriver);
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php?");
        }

        [TestCleanup]
        public void TearDown()
        {
            //webDriver.Close();//Cerrar el browser
            //webDriver.Quit();//Cerrar los procesos

        }

        [TestMethod, TestCategory("ContactUs Invalida data")]
        public void ContactUsFormIsNotSentWithInvalidData()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php?");

            ContactUsPage contactUsPage = navigationSteps.NavigateToContactUs();
        }

        [TestMethod]
        //Validate invalid data shows error message|error message is raised when no data is provided and data is sent
        public void SecondTest()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php?");
           
            IWebElement contactUsButton = webDriver.FindElement(By.Id("contact-link"));
            contactUsButton.Click();
            
            IWebElement sendButton = webDriver.FindElement(By.Id("submitMessage"));
            sendButton.Click();

            IWebElement confirmationLabel = webDriver.FindElement(By.XPath("//div[@class='alert alert-danger']"));

            string actualMesssage = confirmationLabel.Text;
            string expectedMessage = "There 2 is 1 error\r\nInvalid email address.";     

            Assert.AreEqual(expectedMessage, actualMesssage);
        }


        //unit test
    }
}
