using NUnit.Framework;
using SpecFlowProjectPractic.ApiRequests.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProjectPractic
{

    [Binding]
    class UploadPhotoSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private ClientAuthModel _user;
        private string _expectedImage;
        private string _changedImage;

        public UploadPhotoSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _user = _scenarioContext.Get<ClientAuthModel>(Context.User);
        }

        [When(@"I send the request POST to route /images/upload/ with valid body")]
        public void ISendRequestPostToRoureImagesUploadWithValidBody()
        {
            _expectedImage = ClientRequests.SendReguestUploadClientImagesPost(_user.TokenData.Token);
        }

        [When(@"I send the request PATCH to route /client/self/ with valid body")]
        public void ISendRequestPatchToRoureClientSelfWithValidBody()
        {
            _changedImage = ClientRequests.SendReguestUploadClientImagesPatch(_user.TokenData.Token, _expectedImage);
        }

        [Then(@"Client profile photo is uploaded")]
        public void ClientProfilePhotoIsUploaded()
        {
            Assert.AreEqual(_expectedImage, _changedImage);
        }
    }
}
