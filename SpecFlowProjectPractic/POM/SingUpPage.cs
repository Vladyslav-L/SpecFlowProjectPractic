﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectPractic
{
    class SingUpPage
    {
        private readonly IWebDriver _webDriver;

        private static By _firstNameField = By.CssSelector("input[name=first_name]");
        private static By _lastNameField = By.CssSelector("input[name=last_name]");
        private static By _emailField = By.CssSelector("input[name=email]");
        private static By _passwordField = By.CssSelector("input[name=password]");
        private static By _passwordConfirmField = By.CssSelector("input[name=password_confirm]");
        private static By _phoneNumberlField = By.CssSelector("input[name=phone_number]");
        private static By _nextButton = By.CssSelector("[class^=SignupForm__submitButton]");
        private static By _companyNameField = By.CssSelector("input[name=company_name]");
        private static By _companyWebsiteField = By.CssSelector("input[name=company_website]");
        private static By _industryField = By.CssSelector("input[name=industry]");
        private static By _optionTextField = By.CssSelector("[class^=Select__optionText]");
        private static By _locationField = By.CssSelector("input[name=location]");
        private static By _pacMatchedField = By.CssSelector("[class=pac-matched]");
        private static By _signupCompanyFormButton = By.CssSelector("button[class^=SignupCompanyForm__submitButton]");
        private static By _ExceptionMessageForNullFirstName = By.XPath("//*[contains(@name,'first_name')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForNullLastName = By.XPath("//*[contains(@name,'last_name')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForNullEmail = By.XPath("//*[contains(@name,'email')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForInvalidPassword = By.XPath("//*[contains(@name,'password')]/../div[contains(@class,'FormErrorText')]");
        private static By _ExceptionMessageForInvalidPhoneNumber = By.XPath("//*[contains(@name,'phone_number')]/../div[contains(@class,'FormErrorText')]");

        public SingUpPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SingUpPage GoToRegistrationInPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join");
            return this;
        }

        public SingUpPage GoToNextRegistrationInPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/join/company");
            return this;
        }

        public SingUpPage SetFirstName(string firstName)
        {
            _webDriver.FindElement(_firstNameField).SendKeys(firstName);
            return this;
        }

        public SingUpPage SetLastName(string lastName)
        {
            _webDriver.FindElement(_lastNameField).SendKeys(lastName);
            return this;
        }

        public SingUpPage SetEmail(string email)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public SingUpPage SetPassword(string password)
        {
            _webDriver.FindElement(_passwordField).SendKeys(password);
            return this;
        }

        public SingUpPage SetPasswordConfirm(string passwordConfirm)
        {
            _webDriver.FindElement(_passwordConfirmField).SendKeys(passwordConfirm);
            return this;
        }

        public SingUpPage SetPhoneNumber(string phoneNumber)
        {
            _webDriver.FindElement(_phoneNumberlField).SendKeys(phoneNumber);
            return this;
        }

        public void ClickNextButton() =>
            _webDriver.FindElement(_nextButton).Click();

        public SingUpPage SetCompanyName(string companyName)
        {
            _webDriver.FindElement(_companyNameField).SendKeys(companyName);
            return this;
        }

        public SingUpPage SetCompanyWebsite(string companyWebsite)
        {
            _webDriver.FindElement(_companyWebsiteField).SendKeys(companyWebsite);
            return this;
        }

        public SingUpPage SetLocation(string location)
        {
            _webDriver.FindElement(_locationField).SendKeys(location);
            return this;
        }

        public void ClickIndustry() =>
            _webDriver.FindElement(_industryField).Click();

        public void ClickLocation() =>
           _webDriver.FindElement(_locationField).Click();

        public void ClickOptionText() =>
            _webDriver.FindElement(_optionTextField).Click();

        public void ClickPacMatched() =>
            _webDriver.FindElement(_pacMatchedField).Click();

        public void ClickSignupCompanyFormButton() =>
           _webDriver.FindElement(_signupCompanyFormButton).Click();

        public string GetExceptionMessageRequiredFirstName() =>
            _webDriver.FindElement(_ExceptionMessageForNullFirstName).Text;

        public string GetExceptionMessageRequiredLastName() =>
           _webDriver.FindElement(_ExceptionMessageForNullLastName).Text;

        public string GetExceptionMessageRequiredEmail() =>
            _webDriver.FindElement(_ExceptionMessageForNullEmail).GetProperty("innerText");

        public string GetExceptionMessageInvalidPassword() =>
                    _webDriver.FindElement(_ExceptionMessageForInvalidPassword).Text;

        public string GetExceptionMessageInvalidPhoneFormat() =>
                    _webDriver.FindElement(_ExceptionMessageForInvalidPhoneNumber).Text;
    }
}
