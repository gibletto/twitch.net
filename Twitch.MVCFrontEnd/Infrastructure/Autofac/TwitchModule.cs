using System;
using Autofac;
using Autofac.Integration.Mvc;
using RestSharp;
using Twitch.Net.Factories;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;

namespace Twitch.MVCFrontEnd.Infrastructure.Autofac
{
    public class TwitchModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TwitchClientFactory>().As<ITwitchClientFactory>().SingleInstance();
            builder.Register<Func<string, Method, IRestRequest>>(c => (uri, method) =>
                                                                      {
                                                                          var request = new RestRequest(uri, method);
                                                                          //Add any client or auth tokens here
                                                                          //request.AddHeader("Client-ID", "");
                                                                          //request.AddHeader("Authorization", string.Format("OAuth {0}", "oauth-token"));
                                                                          return request;
                                                                      }).AsSelf().SingleInstance();
            builder.Register(c =>
                             {
                                 var restClient = new RestClient("https://api.twitch.tv/kraken");
                                 restClient.AddHandler("application/json", new DynamicJsonDeserializer());
                                 restClient.AddDefaultHeader("Accept", "application/vnd.twitchtv.v2+json");
                                 return restClient;
                             }).As<IRestClient>().SingleInstance();
            builder.Register(c =>
                             {
                                 var restClient = c.Resolve<IRestClient>();
                                 var requestFactory = c.Resolve<Func<string, Method, IRestRequest>>();
                                 return c.Resolve<ITwitchClientFactory>().CreateStaticReadonlyClient(restClient, requestFactory);
                             }).InstancePerHttpRequest();

        }
    }
}