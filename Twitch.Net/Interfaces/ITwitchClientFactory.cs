using System;
using RestSharp;


namespace Twitch.Net.Interfaces
{
    public interface ITwitchClientFactory
    {
        ITwitchStaticClient CreateStaticReadonlyClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory);
        ITwitchClient CreateDynamicReadonlyClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory);
        ITwitchClient CreateDynamicAuthenticatedClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory);
    }
}
