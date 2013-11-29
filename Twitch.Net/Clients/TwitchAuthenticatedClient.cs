using System;
using System.Dynamic;
using RestSharp;
using Twitch.Net.Enums;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;

namespace Twitch.Net.Clients
{
    class TwitchAuthenticatedClient : TwitchReadOnlyClient, IAuthenticatedTwitchClient, IAuthenticatedClientGeneric
    {
        public TwitchAuthenticatedClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory) : base(restClient, requestFactory)
        {
        }

        public dynamic GetUserBlocks(string user, PagingInfo pagingInfo = null)
        {
            return GetUserBlocks<ExpandoObject>(user, pagingInfo);
        }

        public T GetUserBlocks<T>(string user, PagingInfo pagingInfo = null) where T : new()
        {
            var request = RequestFactory("users/{user}/blocks", Method.GET);
            request.AddUrlSegment("user", user);
            AddPaging(request, pagingInfo);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic BlockUser(string myUser, string userToBlock)
        {
            return BlockUser<ExpandoObject>(myUser, userToBlock);
        }

        public T BlockUser<T>(string myUser, string userToBlock) where T : new()
        {
            var request = RequestFactory("users/{user}/blocks/{target}", Method.PUT);
            request.AddUrlSegment("user", myUser);
            request.AddUrlSegment("target", userToBlock);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic DeleteBlock(string myUser, string userToUnblock)
        {
            return DeleteBlock<ExpandoObject>(myUser, userToUnblock);
        }

        public T DeleteBlock<T>(string myUser, string userToUnblock) where T : new()
        {
            var request = RequestFactory("users/{user}/blocks/{target}", Method.DELETE);
            request.AddUrlSegment("user", myUser);
            request.AddUrlSegment("target", userToUnblock);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChannel()
        {
            return GetChannel<ExpandoObject>();
        }

        public T GetChannel<T>() where T : new()
        {
            var request = RequestFactory("channel", Method.GET);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChannelEditors(string channel)
        {
            return GetChannelEditors<ExpandoObject>(channel);
        }

        public T GetChannelEditors<T>(string channel) where T : new()
        {
            var request = RequestFactory("channels/{channel}/editors", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic UpdateChannel(string channel, string status = null, string game = null)
        {
            return UpdateChannel<ExpandoObject>(channel, status, game);
        }

        public T UpdateChannel<T>(string channel, string status = null, string game = null) where T : new()
        {
            var request = RequestFactory("channels/{channel}", Method.PUT);
            request.AddUrlSegment("channel", channel);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new { channel = new { status, game }});
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic ResetStreamKey(string channel)
        {
            return ResetStreamKey<ExpandoObject>(channel);
        }

        public T ResetStreamKey<T>(string channel) where T : new()
        {
            var request = RequestFactory("channels/{channel}/stream_key", Method.DELETE);
            request.AddUrlSegment("channel", channel);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic TriggerCommerical(string channel, CommercialLength length)
        {
            return TriggerCommerical<ExpandoObject>(channel, length);
        }

        public T TriggerCommerical<T>(string channel, CommercialLength length) where T : new()
        {
            var request = RequestFactory("channels/{channel}/commercial", Method.POST);
            request.AddUrlSegment("channel", channel);
            request.AddParameter("length", (int)length);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic FollowChannel(string user, string channel)
        {
            return FollowChannel<ExpandoObject>(user, channel);
        }

        public T FollowChannel<T>(string user, string channel) where T : new()
        {
            var request = RequestFactory("users/{user}/follows/channels/{target}", Method.PUT);
            request.AddUrlSegment("user", user);
            request.AddUrlSegment("target", channel);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic DeleteFollow(string user, string channel)
        {
            return DeleteFollow<ExpandoObject>(user, channel);
        }

        public T DeleteFollow<T>(string user, string channel) where T : new()
        {
            var request = RequestFactory("users/{user}/follows/channels/{target}", Method.DELETE);
            request.AddUrlSegment("user", user);
            request.AddUrlSegment("target", channel);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }
    
        public dynamic GetFollows()
        {
            return GetFollows<ExpandoObject>();
        }

        public T GetFollows<T>() where T : new()
        {
            var request = RequestFactory("streams/followed", Method.GET);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetSubscriptions(string channel)
        {
            return GetSubscriptions<ExpandoObject>(channel);
        }

        public T GetSubscriptions<T>(string channel) where T : new()
        {
            var request = RequestFactory("channels/{channel}/subscriptions", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetUserSubscribedToChannel(string user, string channel)
        {
            return GetUserSubscribedToChannel<ExpandoObject>(user, channel);
        }
      
        public T GetUserSubscribedToChannel<T>(string user, string channel) where T : new()
        {
            var request = RequestFactory("channels/{channel}/subscriptions/{user}", Method.GET);
            request.AddUrlSegment("channel", channel);
            request.AddUrlSegment("user", user);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChannelUserSubscribedTo(string channel, string user)
        {
            return GetChannelUserSubscribedTo<ExpandoObject>(channel, user);
        }

        public T GetChannelUserSubscribedTo<T>(string channel, string user) where T : new()
        {
            var request = RequestFactory("users/{user}/subscriptions/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            request.AddUrlSegment("user", user);
            var response = RestClient.Execute<T>(request);
            return response.Data;
        }
    }
}
