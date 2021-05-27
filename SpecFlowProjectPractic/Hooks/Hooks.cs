using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SpecFlowProjectPractic
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario("ui")]
        public void BeforeScenario()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            var webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _scenarioContext.Add(Context.WebDriver, webDriver);
        }

        [BeforeStep("AccountSettings")]
        public void BeforeStep()
        {
            Thread.Sleep(1000);
            var webDriver = _scenarioContext.Get<IWebDriver>(Context.WebDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        [AfterScenario("ui")]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>(Context.WebDriver).Quit();
        }
    }
}