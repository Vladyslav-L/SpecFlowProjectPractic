using NUnit.Framework;
using SpecFlowProjectPractic.ApiRequests.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic.Steps.API
{
    [Binding]
    class ChangePasswordSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private ClientAuthModel _user;       
        private string _changedPassword;

        public ChangePasswordSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _user = _scenarioContext.Get<ClientAuthModel>(Context.User);
        }

        [When(@"I send the request POST to route /password/change/ with valid body and authorization token")]
        public void ISendTheRequestPostToRourePasswordChangeWithValidBodyAndAuthorizationToken()
        {
            _changedPassword = ClientRequests.SendReguestChangeClientPasswordPost(Constants.Password, Constants.NewPassword, _user.TokenData.Token);
        }

        [Then(@"Client password is changed")]
        public void ClientProfilePhotoIsUploaded()
        {
            Assert.AreEqual(_user.TokenData.Token, _changedPassword);
        }
    }
}
