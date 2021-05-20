using OpenQA.Selenium;

namespace SpecFlowProjectPractic
{
    public class CompanySignUpPage
    {
        private readonly IWebDriver _webDriver;

        public CompanySignUpPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public bool IsPageTitleVisible()
        {
            return true;
        }
    }
}