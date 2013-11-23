using System;
using RestSharp;
using Twitch.Net.Interfaces;

namespace Twitch.Net.Clients
{
    class TwitchAuthenticatedClient : TwitchReadOnlyClient, IAuthenticatedTwitchClient
    {
        public TwitchAuthenticatedClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory) : base(restClient, requestFactory)
        {
        }
    }
}
