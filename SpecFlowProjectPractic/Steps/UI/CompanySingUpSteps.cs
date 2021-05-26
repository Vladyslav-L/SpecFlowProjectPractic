﻿using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic
{
    [Binding]
    public class CompanySignUpSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;
        private readonly CompanySignUpPage _companySignUpPage;

        public CompanySignUpSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _webDriver = _scenarioContext.Get<IWebDriver>(Context.WebDriver);
            _companySignUpPage = new CompanySignUpPage(_webDriver);

        }

        [Then(@"I successfully logged in NewBookModels as created client")]
        public void ThenSuccessfullyLoggedInNewBookModelAsCreatedClient()
        {
            Assert.IsTrue(_companySignUpPage.IsPageTitleVisible());
        }
    }
}