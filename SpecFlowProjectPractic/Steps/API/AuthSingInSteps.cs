using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic
{
    [Binding]
    public class AuthSingInSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public AuthSingInSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Client is created")]
        public void GivenClientIsCreated()
        {
            var createUser = AuthReguests.SendRequestClientSingUpPost(new Dictionary<string, string>
            {
                {"email", $"asda2sd2asd{DateTime.Now:ddyyyymmHHmmssffff}@asdasd.ert"},
                {"first_name", "asdasdasd"},
                {"last_name", "asdasdasd"},
                {"password", Constants.Password},
                {"phone_number", "3453453454"}
            });

            _scenarioContext.Add(Context.User, createUser);
        }

        [When(@"I send the request POST to route /registration with valid body")]
        public void IsendTheRequestPostTorouteRegistrationWithValidBody()
        {
            var createUser = AuthReguests.SendRequestClientSingUpPost(new Dictionary<string, string>
            {
                {"email", $"asda2sd2asd{DateTime.Now:ddyyyymmHHmmssffff}@asdasd.ert"},
                {"first_name", "asdasdasd"},
                {"last_name", "asdasdasd"},
                {"password", Constants.Password},
                {"phone_number", "3453453454"}
            });

            _scenarioContext.Add(Context.User, createUser);
        }

        [When(@"I send the request POST to route /authorization with valid body")]
        public void GivenAuthorizateExistingClientUsingApiRequestPOSTAuthAuth_Client()
        {
            var userData = new Response();
            var user = new Dictionary<string, string>
            {
                { "email", userData.Email },
                {"password", Constants.Password }
            };

            var authrequest = AuthReguests.SendRequestClientSingUpPost(user);
            _scenarioContext.Add("Auth", authrequest);
        }   
    }
}