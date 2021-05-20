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
    }
}