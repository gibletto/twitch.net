using System;
using NUnit.Framework;
using RestSharp;
using System.Configuration;
using Twitch.Net.Clients;
using Twitch.Net.Helpers;

namespace Twitch.Net.Tests.Integration
{
    [TestFixture(Category = "Integration")]

    public class DynamicAuthenticatedClientTests
    {
        private RestClient _restClient;
        private TwitchAuthenticatedClient _twitchClient;
        private readonly string _twitchApiUrl = ConfigurationManager.AppSettings["TwitchAPIUrl"];
        private readonly string _twitchAcceptHeader = ConfigurationManager.AppSettings["TwitchAPIAcceptHeader"];
        private readonly string _twitchUser = ConfigurationManager.AppSettings["TwitchUser"];
        private readonly string _twitchChannel = ConfigurationManager.AppSettings["TwitchChannel"];
        private readonly string _twitchStream = ConfigurationManager.AppSettings["TwitchStream"];
        private readonly string _twitchTeam = ConfigurationManager.AppSettings["TwitchTeam"];
        private readonly string _twitchVideo = ConfigurationManager.AppSettings["TwitchVideo"];
        private readonly string _twitchSearchStream = ConfigurationManager.AppSettings["TwitchSearchStream"];
        private readonly string _twitchSearchGame = ConfigurationManager.AppSettings["TwitchGameStream"];

        [SetUp]
        public void Setup()
        {
            _restClient = new RestClient(_twitchApiUrl);
            _restClient.AddHandler("application/json", new DynamicJsonDeserializer());
            _restClient.AddDefaultHeader("Accept", _twitchAcceptHeader);

            Func<string, Method, IRestRequest> requestFunc = (url, method) => { 
                var restRequest = new RestRequest(url, method);
                restRequest.AddHeader("Client-ID", "fakeclientid");
                restRequest.AddHeader("Authorization", string.Format("OAuth {0}", "fakeauth"));
                return restRequest;
            };
            _twitchClient = new TwitchAuthenticatedClient(_restClient, requestFunc);
        }

        [Test]
        public void Can_Follow_Channel()
        {
            var response = _twitchClient.FollowChannel("gibletto", "somechannel");
            Assert.IsNotNull(response);
        }

        [Test]
        public void Can_Delete_Follow()
        {
            _twitchClient.DeleteFollow("gibletto", "shyboy");
        }

        [Test]
        public void Can_Update_Channel()
        {
            var result = _twitchClient.UpdateChannel("gibletto", "Cool beans!", "Diablo");
            Assert.IsNotNull(result);
        }
    }
}
