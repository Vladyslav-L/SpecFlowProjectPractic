using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectPractic
{
    class AccountSettingsInPage
    {
        private readonly IWebDriver _webDriver;

        private static By _editSwitcherGeneralInformation = By.XPath(
            "//div[contains(text(),'General information')]//..//..//div[contains(@class,'edit-switcher')]");
        private static By _editSwitcherEmail = By.XPath(
            "//div[contains(text(),'E-mail Address')]//..//..//div[contains(@class,'edit-switcher')]");
        private static By _editSwitcherPassword = By.XPath(
            "//div[contains(text(),'Password')]//..//..//div[contains(@class,'edit-switcher')]");
        private static By _editSwitcherPhoneNumber = By.XPath(
            "//div[contains(text(),'Phone Number')]//..//..//div[contains(@class,'edit-switcher')]");
        private static By _cancelField = By.XPath("//div[contains(text(),'CANCEL')]");
        private static By _firstNameField = By.CssSelector("input[placeholder='Enter First Name']");
        private static By _lastNameField = By.CssSelector("input[placeholder='Enter Last Name']");
        private static By _companyLocationField = By.CssSelector("input[placeholder='Enter Company Location']");
        private static By _companyLocation = By.XPath("//span[@class='pac-item-query']/span[@class='pac-matched']");
        private static By _companyLocationForm = By.XPath("//form[1]/div[2]/div[1]/nb-paragraph[3]/div[1]");
        private static By _industryField = By.CssSelector("input[placeholder='Enter Industry']");
        private static By _saveChangesButton = By.XPath("//button[contains(text(),'Save Changes')]");
        private static By _passwordField = By.CssSelector("input[placeholder='Enter Password']");        
        private static By _currentPasswordField = By.XPath("//input[contains(@placeholder ,'Enter Current Password')]");
        private static By _newPasswordField = By.CssSelector("input[placeholder = 'Enter New Password']");
        private static By _reTypeNewPasswordField = By.XPath(
            "//input[contains(@placeholder ,'Enter New Password')]//..//..//..//div[contains(text(),'Re-type New Password')]");
        private static By _editPasswordField = By.CssSelector("//div[3]/div[1]/nb-account-info-password[1]/form[1]/div[1]/div[1]/nb-edit-switcher[1]/div[1]/div[1]");
        private static By _emailField = By.CssSelector("input[placeholder='Enter E-mail']");
        private static By _logoutField = By.CssSelector("[class='link link_type_logout link_active']");
        private static By _fullNameField = By.CssSelector("input[placeholder='Full name']");
        private static By _cardNumberField = By.CssSelector("input[placeholder='Card number']");
        private static By _cvcField = By.CssSelector("input[placeholder='CVC']");
        private static By _mmYyField = By.CssSelector("input[placeholder='MM / YY']");
        private static By _saveButton = By.XPath("//button[contains(text(),'Save')]");
        private static By _stripeField = By.CssSelector("input[class='StripeField--fake']");
        private static By _updateErrorMessage = By.XPath("//span[contains(text(),'Update card info unexpected error')]");
        private static By _phoneNumber = By.XPath("//input[contains(@placeholder ,'555.222.5555')]");
        private static By _phoneNumberField = By.XPath("//span[contains(@class,'font-weight-bold')]//../../div[contains(text(),'Phone Number')]");
        private static By _currentEmailField = By.XPath("//div[contains(text(),' Current email: ')]");
            
        public AccountSettingsInPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AccountSettingsInPage GoToAccountSettingsInPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/account-settings/account-info/edit");
            return this;
        }

        public AccountSettingsInPage SetFirstName(string firstName)
        {
            _webDriver.FindElement(_firstNameField).Clear();
            _webDriver.FindElement(_firstNameField).SendKeys(firstName);            
            return this;
        }

        public AccountSettingsInPage SetLastName(string lastName)
        {
            _webDriver.FindElement(_lastNameField).Clear(); 
            _webDriver.FindElement(_lastNameField).SendKeys(lastName);
            return this;
        }

        public AccountSettingsInPage SetCompanyLocation(string companyLocation)
        {
            _webDriver.FindElement(_companyLocationField).SendKeys(companyLocation);
            return this;
        }

        public AccountSettingsInPage SetIndustry(string industry)
        {
            _webDriver.FindElement(_industryField).SendKeys(industry);
            return this;
        }

        public AccountSettingsInPage SetPassword(string password)
        {
            _webDriver.FindElement(_passwordField).SendKeys(password);
            return this;
        }

        public AccountSettingsInPage SetCurrentPassword(string password)
        {
            _webDriver.FindElement(_currentPasswordField).SendKeys(password);
            return this;
        }

        public AccountSettingsInPage SetNewPassword(string password)
        {
            _webDriver.FindElement(_newPasswordField).SendKeys(password);
            return this;
        }

        public AccountSettingsInPage SetReTypeNewPassword(string password)
        {
            _webDriver.FindElement(_reTypeNewPasswordField).SendKeys(password);
            return this;
        }

        public AccountSettingsInPage SetEmail(string email)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public AccountSettingsInPage SetFullName(string fullName)
        {
            _webDriver.FindElement(_fullNameField).SendKeys(fullName);
            return this;
        }

        public AccountSettingsInPage SetCardNumber(string cardNumber)
        {
            _webDriver.FindElement(_cardNumberField).SendKeys(cardNumber);
            return this;
        }

        public AccountSettingsInPage SetMmYy(string mmYy)
        {
            _webDriver.FindElement(_mmYyField).SendKeys(mmYy);
            return this;
        }

        public AccountSettingsInPage SetCvc(string cvc)
        {
            _webDriver.FindElement(_cvcField).SendKeys(cvc);
            return this;
        }

         public AccountSettingsInPage SetPhoneNumber(string phoneNumber)
        {
            _webDriver.FindElement(_phoneNumber).SendKeys(phoneNumber);
            return this;
        }

        public void ClickEditSwitcherGeneralInformation() =>
            _webDriver.FindElement(_editSwitcherGeneralInformation).Click();

        public void ClickEditSwitcherEmail() =>
            _webDriver.FindElement(_editSwitcherEmail).Click();

         public void ClickEditSwitcherPassword() =>
            _webDriver.FindElement(_editSwitcherPassword).Click();

         public void ClickEditSwitcherPhoneNumber() =>
            _webDriver.FindElement(_editSwitcherPhoneNumber).Click();

        public void ClickCompanyLocation() =>
            _webDriver.FindElement(_companyLocation).Click();

        public void ClickSaveChanges() =>
            _webDriver.FindElement(_saveChangesButton).Click();

        public void ClickLogout() =>
           _webDriver.FindElement(_logoutField).Click();

        public void ClickEditPassword() =>
           _webDriver.FindElement(_editPasswordField).Click();

        public string GetCompanyLocation() =>
            _webDriver.FindElement(_companyLocationForm).Text;

        public string GetUpdateErrorMessage() =>
           _webDriver.FindElement(_updateErrorMessage).GetAttribute("class");

        public string GetUpdateNumber() =>
           _webDriver.FindElement(_phoneNumberField).Text;
        public string GetUpdateEmail() =>
           _webDriver.FindElement(_currentEmailField).Text;
         public string GetUpdateHolderName(string name) =>
           _webDriver.FindElement(By.XPath($"//div[contains(text(),'{name}')]")).Text;

        public void ClickSaveCard() =>
            _webDriver.FindElement(_saveButton).Click();

        public string GetCardNumber() =>
            _webDriver.FindElement(_cardNumberField).Text;

        public void ClickStripeField() =>
           _webDriver.FindElement(_stripeField).Click();
    }
}
