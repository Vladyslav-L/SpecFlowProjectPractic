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
    class ChangeGeneralInformationSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private ClientAuthModel _user;
        private string _changedLocation;
        private string _changedFirstName;
        private string _changedLastName;
        private string _changedIndustry;

        public ChangeGeneralInformationSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _user = _scenarioContext.Get<ClientAuthModel>(Context.User);
        }

        [When(@"I send the request PATCH to route /client/self/ with valid body and authorization token")]
        public void ISendTheRequestPatchToRoureClientSelfWithValidBodyAndAuthorizationToken()
        {
            _changedFirstName = ClientRequests.SendReguestChangeClientFirstNamePatch(Constants.FirstName, Constants.LastName, _user.TokenData.Token);
        }

        [When(@"I send the request PATCH to route /client/self/ with valid body and authorization token for change last name")]
        public void ISendTheRequestPatchToRoureClientSelfWithValidBodyAndAuthorizationTokenForChangeLastName()
        {
            _changedLastName = ClientRequests.SendReguestChangeClientLastNamePatch(Constants.LastName, _user.TokenData.Token);
        }

        [When(@"I send the request PATCH to route /client/profile/ with valid body and authorization token")]
        public void ISendTheRequestPatchToRoureClientProfileWithValidBodyAndAuthorizationToken()
        {
            _changedLocation = ClientRequests.SendReguestChangeClientCompanyLocationPatch(Constants.Location, _user.TokenData.Token);
        }

        [When(@"I send the request PATCH to route /client/profile/ with valid body and authorization token for change industry")]
        public void ISendTheRequestPacthToRoureClientProfileWithValidBodyAndAuthorizationToken()
        {
            _changedIndustry = ClientRequests.SendReguestChangeClientIndustryPatch(Constants.Industry, _user.TokenData.Token);
        }

        [Then(@"Client industry is changed")]
        public void ThenClientIndustryIsChanged()
        {
            Assert.AreEqual(Constants.Industry, _changedIndustry);
        }

        [Then(@"Client first name is changed")]
        public void ThenClientFirstNameIsChanged()
        {
            Assert.AreEqual(Constants.FirstName, _changedFirstName);
        }

        [Then(@"Client last name is changed")]
        public void ThenClientLastNameIsChanged()
        {
            Assert.AreEqual(Constants.LastName, _changedLastName);
        }

        [Then(@"Client company location is changed")]
        public void ThenClientLocationIsChanged()
        {
            Assert.AreEqual(Constants.Location, _changedLocation);
        }


    }
}
