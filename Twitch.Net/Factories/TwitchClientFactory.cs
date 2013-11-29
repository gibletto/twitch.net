using System;
using RestSharp;
using Twitch.Net.Clients;
using Twitch.Net.Interfaces;

namespace Twitch.Net.Factories
{
    public class TwitchClientFactory : ITwitchClientFactory
    {
        public ITwitchStaticClient CreateStaticReadonlyClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory)
        {
            return new TwitchStaticReadOnlyClient(new TwitchReadOnlyClient(restClient, requestFactory));
        }

        public ITwitchClient CreateDynamicReadonlyClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory)
        {
            return new TwitchReadOnlyClient(restClient, requestFactory);
        }
    }
}