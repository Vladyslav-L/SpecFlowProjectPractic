﻿using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace SpecFlowProjectPractic
{
    public static class AuthReguests
    {
        public static ClientAuthModel SendRequestClientSingUpPost(Dictionary<string, string> user)
        {
            var client = new RestClient("https://api.newbookmodels.com/api/v1/auth/client/signup/");
            var request = new RestRequest(Method.POST);

            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(user);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);
            var createdUser = JsonConvert.DeserializeObject<ClientAuthModel>(response.Content);

            return createdUser;
        }
    }
}
