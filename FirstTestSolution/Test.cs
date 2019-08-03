using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectLibrary.AutomationPractice.ContactUs;
using PageObjectLibrary.AutomationPractice.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestSolution
{
    //decorator para el unit test (en esta clase existen test)
    [TestClass]
    public class Test
    {

        IWebDriver webDriver;
        public Test()
        {
            webDriver = new ChromeDriver(@"C:\SeleniumWebDrivers");
        }

        [TestMethod]
        public void MyFirstTest()
        {
            //navigate to automation practice site
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php?");

            MenuPage menuPage = new MenuPage(webDriver);
            menuPage.ClickContactUs();

            ContactUsPage contactUsPage = new ContactUsPage(webDriver);

            contactUsPage.FillContactUsForm(ContactUsPage.Options.ByText,"Customer service", "juan.pablo.delgadillo.peredo@gmail.com", "1234", @"C:\test.txt", "Hola, compraste esto");

            string actualMessage= contactUsPage.GetConfirmationMessage();
            string expectedMessage = "Your message has been successfully sent to our team.";

            Assert.AreEqual(expectedMessage, actualMessage);

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
