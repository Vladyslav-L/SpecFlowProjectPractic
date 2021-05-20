using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic
{
    [Binding]
    public class SignInSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly SingInPage _singInPage;

        public SignInSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>(Context.WebDriver);
            _singInPage = new SingInPage(_webDriver);
        }

        [Given(@"Sign in page is opened")]
        public void GivenSignInPageIsOpened()
        {
            _singInPage.GoToSingInPage();
        }

        [When(@"I input valid data of created client")]
        public void WhenIInputValidDataOfCreatedClient()
        {
            var user = _scenarioContext.Get<ClientAuthModel>(Context.User);
            _singInPage.SetEmail(user.User.Email);
            _singInPage.SetPassword(Constants.Password);
        }

        [When(@"I input email (.*) in email field")]
        public void WhenIInputEmailInEmailField(string email)
        {
            _singInPage.SetEmail(email);
        }

        [When(@"I input email of created client in email field")]
        public void WhenIInputEmailOfCreatedClientInEmailField()
        {
            var user = _scenarioContext.Get<ClientAuthModel>(Context.User);
            _singInPage.SetEmail(user.User.Email);
        }

        [When(@"I input password (.*) in password field")]
        public void WhenIInputPasswordInPasswordField(string password)
        {
            _singInPage.SetPassword(password);
        }

        [When(@"I input password of created client in password field")]
        public void WhenIInputPasswordOfCreatedClientInEmailField()
        {
            _singInPage.SetPassword(Constants.Password);
        } 
        
        [When(@"I click Log in button")]
        public void WhenIClickLogInButton()
        {
            _singInPage.ClickSingUp();
        }

        [Then(@"Displayed exception message for login field in Sing in page: (.*)")]
        public void DisplayedExceptionMessageForEmail(string message)
        {
            Assert.AreEqual(message,_singInPage.GetExceptionMessageForEmailField());
        }

         [Then(@"Displayed exception message for invalid data in Sing in page: (.*)")]
        public void DisplayedExceptionMessage(string message)
        {
            Assert.AreEqual(message,_singInPage.GetExceptionMessageForInvalidData());
        }
    }
}