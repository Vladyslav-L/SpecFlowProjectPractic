using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic.Steps.UI
{

    [Binding]
    public class AccountSettingsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly AccountSettingsInPage _accountSettingsInPage;        

        public AccountSettingsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>(Context.WebDriver);
            _accountSettingsInPage = new AccountSettingsInPage(_webDriver);
        }

        [When(@"Account Settings page is opened")]
        public void WhenAccountSettingsPageIsOpened()
        {
            _accountSettingsInPage.GoToAccountSettingsInPage();
        }

        [When(@"I click edit button for general information")]
        public void WhenIClickEditButtonForGeneralInformation()
        {
            _accountSettingsInPage.ClickEditSwitcherGeneralInformation();
        }

        [When(@"I click edit button for email")]
        public void WhenIClickEditButtonForEmail()
        {
            _accountSettingsInPage.ClickEditSwitcherEmail();
        }

        [When(@"I click edit button for password")]
        public void WhenIClickEditButtonForPassword()
        {
            _accountSettingsInPage.ClickEditSwitcherPassword();
        }

        [When(@"I click edit button for phone number")]
        public void WhenIClickEditButtonForPhoneNumber()
        {
            _accountSettingsInPage.ClickEditSwitcherPhoneNumber();
        }

        [When(@"I fill first name (.*) in first name field for Account Settings page")]
        public void WhenIFillFirstNameInFirstNameFieldForAccountSettingsPage(string firstName)
        {
            _accountSettingsInPage.SetFirstName(firstName);
        }

        [When(@"I fill last name (.*) in last name field for Account Settings page")]
        public void WhenIFillLastNameInLastNameFieldForAccountSettingsPage(string lastName)
        {
            _accountSettingsInPage.SetLastName(lastName);
        }

        [When(@"I fill industry (.*) in industry field for Account Settings page")]
        public void WhenIFillIndustryInIndustryFieldForAccountSettingsPage(string industry)
        {
            _accountSettingsInPage.SetIndustry(industry);
        }

        [When(@"I fill company location (.*) in company location field for Account Settings page")]
        public void WhenIFillConpanyLocationInCompanyLocationFieldForAccountSettingsPage(string companyLocation)
        {
            _accountSettingsInPage.SetCompanyLocation(companyLocation);
        }

        [When(@"I click company location button for Account Settings page")]
        public void WhenIClickConpanyLocationInConpanyLocationFieldForAccountSettingsPage()
        {
            _accountSettingsInPage.ClickCompanyLocation();
        }

        [When(@"I click Save Changes button for general information in Account Settings page")]
        public void WhenIClickSaveChangesButtonForGeneralInformationInAccountSettingsPage()
        {
            _accountSettingsInPage.ClickSaveChanges();
        }

        [When(@"I fill old password in old password field for Account Settings page")]
        public void WhenIFillOldPasswordInOldPasswordFiledForAccountSettingsPage()
        {
            _accountSettingsInPage.SetCurrentPassword("");
        }

        [When(@"I fill new password in new password field for Account Settings page")]
        public void WhenIFillNewPasswordInNewPasswordFiledForAccountSettingsPage()
        {
            _accountSettingsInPage.SetNewPassword("");
        }

        [When(@"I fill confirm password in confirm password field for Account Settings page")]
        public void WhenIFillConfirmPasswordInConfirmPasswordFiledForAccountSettingsPage()
        {
            _accountSettingsInPage.SetReTypeNewPassword("");
        }

        [When(@"I click Save Changes button for password in Account Settings page")]
        public void WhenIClickSaveChangesButtonForPasswordInAccountSettingsPage()
        {
            _accountSettingsInPage.ClickSaveChanges();
        }

        [When(@"I fill password in password field for Account Settings page")]
        public void WhenIFillPasswordInPasswordFieldForAccountSettingsPage()
        {
            _accountSettingsInPage.SetPassword(Constants.Password);
        }

        [When(@"I fill new email in new email field for Account Settings page")]
        public void WhenIFillNewEmailInNewEmailFieldForAccountSettingsPage()
        {
            _accountSettingsInPage.SetEmail(UniqData.Email);
        }

        [When(@"I click Save Changes button for email in Account Settings page")]
        public void WhenIClickSaveChangesButtonForEmailInAccountSettingsPage()
        {
            _accountSettingsInPage.ClickSaveChanges();
        }

        [When(@"I fill current password in password field for Account Settings page")]
        public void WhenIfillCurrentPassordInPassordFieldForAccountSettingsPage()
        {
            _accountSettingsInPage.SetPassword(Constants.Password);
        }

        [When(@"I fill phone number in new phone number field for Account Settings page")]
        public void WhenIfillhoneNumberInNewPhoneNumberFieldForAccountSettingsPage()
        {
            _accountSettingsInPage.SetPhoneNumber("1111111111");
        }

        [Then(@"Phone number is changed")]
        public void ThenPhoneNumberIsChanged()
        {
            Assert.AreEqual("Phone Number: 111.111.1111", _accountSettingsInPage.GetUpdateNumber());
        }

        [Then(@"Email is changed")]
        public void ThenEmailIsChanged()
        {
            Assert.AreEqual($"Current email: {UniqData.Email}", _accountSettingsInPage.GetUpdateEmail());
        }

        [Then(@"Account settings is changed")]
        public void ThenAccountSettingsIsChanged()
        {           
            Assert.AreEqual($"{Constants.FirstName} {Constants.LastName}",_accountSettingsInPage.GetUpdateHolderName(Constants.FirstName));
        }

        //[When(@"I fill first name in first name field for Account Settings page")]
        //public void WhenIClickEditButtonForPhoneNumber()
        //{
        //    _accountSettingsInPage.ClickEditSwitcherPhoneNumber();
        //}

    }

}
