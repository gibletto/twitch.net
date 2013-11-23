using System.Dynamic;
using RestSharp;
using System;
using Twitch.Net.Enums;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;

namespace Twitch.Net.Clients
{
    public class TwitchReadOnlyClient : ITwitchClient
    {
        private readonly IRestClient _restClient;
        private readonly Func<string, Method, IRestRequest> _requestFactory;

        public TwitchReadOnlyClient(IRestClient restClient, Func<string, Method, IRestRequest> requestFactory)
        {
            _restClient = restClient;
            _requestFactory = requestFactory;
        }

        public dynamic GetUser(string user)
        {
            var request = _requestFactory("users/{user}", Method.GET);
            request.AddUrlSegment("user", user);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetChannel(string channel)
        {
            var request = _requestFactory("channels/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetChannelVideos(string channel)
        {
            var request = _requestFactory("channels/{channel}/videos", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetChatLinks(string channel)
        {
            var request = _requestFactory("chat/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetEmoticons()
        {
            var request = _requestFactory("chat/emoticons", Method.GET);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetChannelFollowers(string channel, PagingInfo pagingInfo = null)
        {
            var request = _requestFactory("channels/{channel}/follows", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetUserFollows(string user, PagingInfo pagingInfo = null)
        {
            var request = _requestFactory("users/{user}/follows/channels", Method.GET);
            request.AddUrlSegment("user", user);
            AddPaging(request, pagingInfo);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        
        public dynamic GetUserFollowingChannel(string user, string channel)
        {
            var request = _requestFactory("users/{user}/follows/channels/{channel}", Method.GET);
            request.AddUrlSegment("user", user);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            var request = _requestFactory("games/top", Method.GET);
            AddPaging(request, pagingInfo);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetIngests()
        {
            var request = _requestFactory("ingests", Method.GET);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetRoot()
        {
            var request = _requestFactory("/", Method.GET);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic SearchStreams(string query, PagingInfo pagingInfo = null)
        {
            var request = _requestFactory("search/streams", Method.GET);
            request.AddParameter("q", query);
            AddPaging(request, pagingInfo);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic SearchGames(string query, SearchType searchType = SearchType.Suggest, bool live = false)
        {
            var request = _requestFactory("search/games", Method.GET);
            request.AddParameter("q", query);
            request.AddParameter("type", searchType.ToString().ToLower());
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetStream(string channel)
        {
            var request = _requestFactory("streams/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetStreams(string game = null, string channel = null, PagingInfo pagingInfo = null, bool embeddableOnly = false, bool httpLiveStreaming = false)
        {
            var request = _requestFactory("streams", Method.GET);
            request.AddParameter("game", game);
            request.AddParameter("channel", game);
            AddPaging(request, pagingInfo);
            request.AddParameter("embeddable", embeddableOnly);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetFeaturedSteams(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            var request = _requestFactory("streams/featured", Method.GET);
            AddPaging(request, pagingInfo);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetStreamsSummary(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            var request = _requestFactory("streams/summary", Method.GET);
            AddPaging(request, pagingInfo);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetTeams()
        {
            var request = _requestFactory("teams", Method.GET);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetTeam(string team)
        {
            var request = _requestFactory("teams/{team}", Method.GET);
            request.AddUrlSegment("team", team);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetVideo(string id)
        {
            var request = _requestFactory("videos/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        public dynamic GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.Week)
        {
            var request = _requestFactory("videos/top", Method.GET);
            var response = _restClient.Execute<ExpandoObject>(request);
            return response.Data;
        }

        private void AddPaging(IRestRequest request, PagingInfo pagingInfo)
        {
            if (pagingInfo == null) return;
            request.AddParameter("limit", pagingInfo.PageSize);
            request.AddParameter("offset", pagingInfo.Page - 1);
        }
    }
}
