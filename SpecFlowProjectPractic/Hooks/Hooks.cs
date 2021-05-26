using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _scenarioContext.Add(Context.WebDriver, driver);
        }

        [BeforeStep]
        public void BeforeStep()
        {
            Thread.Sleep(2000);
            var driver = _scenarioContext.Get<IWebDriver>(Context.WebDriver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>(Context.WebDriver).Quit();
        }
    }
}