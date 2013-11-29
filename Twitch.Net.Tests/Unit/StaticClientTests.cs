using System;
using System.Configuration;
using System.Dynamic;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using Rhino.Mocks;
using Twitch.Net.Clients;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;

namespace Twitch.Net.Tests.Unit
{
    [TestFixture]
    public class StaticClientTests
    {
        private TwitchStaticReadOnlyClient _twitchClient;
        private ITwitchClientGeneric _wrappedClient;
        [SetUp]
        public void Setup()
        {
            _wrappedClient = MockRepository.GenerateMock<ITwitchClientGeneric>();
        }
        [Test]
        public void Can_Retrieve_Root_From_Json()
        {
            var json = @"{
                          ""token"": {
                            ""authorization"": {
                              ""scopes"": [""user_read"", ""channel_read"", ""channel_commercial"", ""user_read""],
                              ""created_at"": ""2012-05-08T21:55:12Z"",
                              ""updated_at"": ""2012-05-17T21:32:13Z""
                            },
                            ""user_name"": ""test_user1"",
                            ""valid"": true
                          },
                          ""_links"": {
                            ""channel"": ""https://api.twitch.tv/kraken/channel"",
                            ""users"": ""https://api.twitch.tv/kraken/users/test_user1"",
                            ""user"": ""https://api.twitch.tv/kraken/user"",
                            ""channels"": ""https://api.twitch.tv/kraken/channels/test_user1"",
                            ""chat"": ""https://api.twitch.tv/kraken/chat/test_user1"",
                            ""streams"": ""https://api.twitch.tv/kraken/streams"",
                            ""ingests"":""https://api.twitch.tv/kraken/ingests""
                          }
                        }";
            
            var convertedJson = JsonConvert.DeserializeObject<RootResult>(json);
            _wrappedClient.Stub(x => x.GetRoot<RootResult>()).Return(convertedJson);
            _twitchClient = new TwitchStaticReadOnlyClient(_wrappedClient);
            var result = _twitchClient.GetRoot();
            Assert.That(result != null);
            Assert.That(result.Token != null);
            foreach (var str in result.Token.Authorization.Scopes)
            {
                Assert.That(str != null);
            }
        }
    }
}
