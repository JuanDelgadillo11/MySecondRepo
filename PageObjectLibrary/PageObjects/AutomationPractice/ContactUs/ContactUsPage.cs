using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectLibrary.Base;

namespace PageObjectLibrary.AutomationPractice.ContactUs
{
    public class ContactUsPage:BasePage
    {
        #region web controls
        private IWebElement subjectHeading = GetDriver().FindElement(By.Id("id_contact"));
        private IWebElement emailAddress = GetDriver().FindElement(By.Name("from"));
        private IWebElement orderReferenceInput = GetDriver().FindElement(By.Name("id_order"));
        private IWebElement attachFile = GetDriver().FindElement(By.Id("fileUpload"));
        private IWebElement messageInput = GetDriver().FindElement(By.Id("message"));
        private IWebElement sendButton = GetDriver().FindElement(By.Id("submitMessage"));       
        #endregion

        public enum Options
        {
            ByText,
            ByValue,
            ByIndex
        }

        public void SelectHeadingComboBox(Options option, string value)
        {
            SelectElement subjectHeadingComboBox = new SelectElement(subjectHeading);
            switch (option)
            {
                case Options.ByText:
                    subjectHeadingComboBox.SelectByText(value);
                    break;
                case Options.ByValue:
                    subjectHeadingComboBox.SelectByValue(value);
                    break;
                case Options.ByIndex:
                    subjectHeadingComboBox.SelectByIndex(int.Parse(value));
                    break;
            }
            
        }

        public void SetEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void SetOrderReference(string orderReference)
        {              
            orderReferenceInput.SendKeys(orderReference);
        }

        public void SetAttachFile(string filePath)
        {            
            attachFile.SendKeys(filePath);
        }

        public void SetMessage(string message)
        {            
            messageInput.SendKeys(message);
        }

        public void ClickSend()
        {            
            sendButton.Click();
        }
        
        public void FillContactUsForm(Options option, string value, string email, string orderReference, string filePath, string message)
        {
            SelectHeadingComboBox(option, value);
            SetEmailAddress(email);
            SetOrderReference(orderReference);
            SetAttachFile(filePath);
            SetMessage(message);
            ClickSend();
        }
    }
}
