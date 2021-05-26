using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic
{
    [Binding]
    public class SignUpSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly SingUpPage _singUpPage;

        public SignUpSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>(Context.WebDriver);
            _singUpPage = new SingUpPage(_webDriver);
        }

        [Given(@"Sign up page is opened")]
        public void GivenSignUnPageIsOpened()
        {
            _singUpPage.GoToRegistrationInPage();
        }

        [When(@"I registration user using data")]
        public void WhenIRegistrationUserUsingData(Table table)
        {
            var firstName = table.Rows[0]["First name"];
            var lastName = table.Rows[0]["Last name"];
            var email = table.Rows[0]["Email"];
            var password = table.Rows[0]["Password"];
            var confirmPassword = table.Rows[0]["Confirm password"];
            var mobile = table.Rows[0]["Mobile"];
            _singUpPage.SetFirstName(firstName);
            _singUpPage.SetLastName(lastName);
            _singUpPage.SetEmail(email);
            _singUpPage.SetPassword(password);
            _singUpPage.SetPasswordConfirm(confirmPassword);
            _singUpPage.SetPhoneNumber(mobile);
        }

        [When(@"I click Next button")]
        public void WhenIClickLogInButton()
        {
            _singUpPage.ClickNextButton();
        }

        [When(@"I fill empty first name in first name field for Sing Up page")]
        public void WhenIFillFirstName()
        {        
            _singUpPage.SetFirstName("");            
        }

        [When(@"I fill empty last name in last name field for Sing Up page")]
        public void WhenIFillLastName()
        {
            _singUpPage.SetLastName("");
        }

        [When(@"I fill email (.*) in email field for Sing Up page")]
        public void WhenIFillEmail(string email)
        {
            _singUpPage.SetEmail(email);
        }

        [When(@"I fill password (.*) in password field for Sing Up page")]
        public void WhenIFillPassword(string password)
        {
            _singUpPage.SetPassword(password);
        }

        [When(@"I fill mobile (.*) in mobile field for Sing Up page")]
        public void WhenIFillMobile(string mobile)
        {
            _singUpPage.SetPhoneNumber(mobile);
        }

        [Then(@"Displayed exception message: (.*) for first name field for Sing Up page")]
        public void DisplayedExceptionMessageForFirstNameFieldSingUpPage(string message)
        {
            Assert.AreEqual(message,_singUpPage.GetExceptionMessageRequiredFirstName());
        }

        [Then(@"Displayed exception message: (.*) for last name field for Sing Up page")]
        public void DisplayedExceptionMessageForLastNameFieldSingUpPage(string message)
        {
            Assert.AreEqual(message,_singUpPage.GetExceptionMessageRequiredLastName());
        }

        [Then(@"Displayed exception message (.*) for password field for Sing Up page")]
        public void DisplayedExceptionMessageForPasswordFieldSingUpPage(string message)
        {
            //var message = table.Rows[0]["Message"];
            Assert.AreEqual(message, _singUpPage.GetExceptionMessageInvalidPassword());
        }

        [Then(@"Displayed exception message (.*) for email field for Sing Up page")]
        public void DisplayedExceptionMessageForEmailFieldSingUpPage(string message)
        {
            //var message = table.Rows[0]["Message"];
            Assert.AreEqual(message, _singUpPage.GetExceptionMessageRequiredEmail());
        }

        [Then(@"Displayed exception message (.*) for mobile field for Sing Up page")]
        public void DisplayedExceptionMessageForMobileFieldSingUpPage(string message)
        {
            //Table table
            //var message = table.Rows[0]["Message"];
            Assert.AreEqual(message, _singUpPage.GetExceptionMessageInvalidPhoneFormat());
        }
    }
}