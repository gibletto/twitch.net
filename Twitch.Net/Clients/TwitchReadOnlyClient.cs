using System.Dynamic;
using RestSharp;
using System;
using Twitch.Net.Enums;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;

namespace Twitch.Net.Clients
{
    public class TwitchReadOnlyClient : ITwitchClient, ITwitchClientGeneric
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
            return GetUser<ExpandoObject>(user);
        }

        public T GetUser<T>(string user) where T : new()
        {
            var request = _requestFactory("users/{user}", Method.GET);
            request.AddUrlSegment("user", user);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChannel(string channel)
        {
            return GetChannel<ExpandoObject>(channel);
        }

        public T GetChannel<T>(string channel) where T : new()
        {
            var request = _requestFactory("channels/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChannelVideos(string channel, PagingInfo pagingInfo = null, bool onlyBroadcasts = false)
        {
            return GetChannelVideos<ExpandoObject>(channel, pagingInfo, onlyBroadcasts);
        }

        public T GetChannelVideos<T>(string channel, PagingInfo info = null, bool onlyBroadcasts = false) where T : new()
        {
            var request = _requestFactory("channels/{channel}/videos", Method.GET);
            request.AddUrlSegment("channel", channel);
            AddPaging(request, info);
            request.AddParameter("broadcasts", onlyBroadcasts);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChatLinks(string channel)
        {
            return GetChatLinks<ExpandoObject>(channel);
        }

        public T GetChatLinks<T>(string channel) where T : new()
        {
            var request = _requestFactory("chat/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetEmoticons()
        {
            return GetEmoticons<ExpandoObject>();
        }

        public T GetEmoticons<T>() where T : new()
        {
            var request = _requestFactory("chat/emoticons", Method.GET);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetChannelFollowers(string channel, PagingInfo pagingInfo = null)
        {
            return GetChannelFollowers<ExpandoObject>(channel, pagingInfo);
        }

        public T GetChannelFollowers<T>(string channel, PagingInfo pagingInfo = null) where T : new()
        {
            var request = _requestFactory("channels/{channel}/follows", Method.GET);
            request.AddUrlSegment("channel", channel);
            AddPaging(request, pagingInfo);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetUserFollows(string user, PagingInfo pagingInfo = null)
        {
            return GetUserFollows<ExpandoObject>(user, pagingInfo);
        }

        public T GetUserFollows<T>(string user, PagingInfo pagingInfo = null) where T : new()
        {
            var request = _requestFactory("users/{user}/follows/channels", Method.GET);
            request.AddUrlSegment("user", user);
            AddPaging(request, pagingInfo);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetUserFollowingChannel(string user, string channel)
        {
            return GetUserFollowingChannel<ExpandoObject>(user, channel);
        }

        public T GetUserFollowingChannel<T>(string user, string channel) where T : new()
        {
            var request = _requestFactory("users/{user}/follows/channels/{channel}", Method.GET);
            request.AddUrlSegment("user", user);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            return GetTopGames<ExpandoObject>(pagingInfo, httpLiveStreaming);
        }

        public T GetTopGames<T>(PagingInfo pagingInfo = null, bool httpLiveStreaming = false) where T : new()
        {
            var request = _requestFactory("games/top", Method.GET);
            AddPaging(request, pagingInfo);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetIngests()
        {
            return GetIngests<ExpandoObject>();
        }

        public T GetIngests<T>() where T : new()
        {
            var request = _requestFactory("ingests", Method.GET);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetRoot()
        {
            return GetRoot<ExpandoObject>();
        }

        public T GetRoot<T>() where T : new()
        {
            var request = _requestFactory("/", Method.GET);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic SearchStreams(string query, PagingInfo pagingInfo = null)
        {
            return SearchStreams<ExpandoObject>(query, pagingInfo);
        }

        public T SearchStreams<T>(string query, PagingInfo info = null) where T : new()
        {
            var request = _requestFactory("search/streams", Method.GET);
            request.AddParameter("q", query);
            AddPaging(request, info);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic SearchGames(string query, SearchType searchType = SearchType.suggest, bool live = false)
        {
            return SearchGames<ExpandoObject>(query, searchType, live);
        }

        public T SearchGames<T>(string query, SearchType searchType = SearchType.suggest, bool live = false) where T : new()
        {
            var request = _requestFactory("search/games", Method.GET);
            request.AddParameter("q", query);
            request.AddParameter("type", searchType.ToString().ToLower());
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetStream(string channel)
        {
            return GetStream<ExpandoObject>(channel);
        }

        public T GetStream<T>(string channel) where T : new()
        {
            var request = _requestFactory("streams/{channel}", Method.GET);
            request.AddUrlSegment("channel", channel);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetStreams(string game = null, string channel = null, PagingInfo pagingInfo = null, bool embeddableOnly = false, bool httpLiveStreaming = false)
        {
            return GetStreams<ExpandoObject>(game, channel, pagingInfo, embeddableOnly, httpLiveStreaming);
        }

        public T GetStreams<T>(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false, bool httpLiveStreaming = false) where T : new()
        {
            var request = _requestFactory("streams", Method.GET);
            request.AddSafeParameter("game", game);
            request.AddSafeParameter("channel", channel);
            AddPaging(request, info);
            request.AddParameter("embeddable", embeddableOnly);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetFeaturedSteams(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            return GetFeaturedSteams<ExpandoObject>(pagingInfo, httpLiveStreaming);
        }

        public T GetFeaturedSteams<T>(PagingInfo info = null, bool httpLiveStreaming = false) where T : new()
        {
            var request = _requestFactory("streams/featured", Method.GET);
            AddPaging(request, info);
            request.AddParameter("hls", httpLiveStreaming);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetStreamSummary()
        {
            return GetStreamSummary<ExpandoObject>();
        }

        public T GetStreamSummary<T>() where T : new()
        {
            var request = _requestFactory("streams/summary", Method.GET);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetTeams()
        {
            return GetTeams<ExpandoObject>();
        }

        public T GetTeams<T>() where T : new()
        {
            var request = _requestFactory("teams", Method.GET);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetTeam(string team)
        {
            return GetTeam<ExpandoObject>(team);
        }

        public T GetTeam<T>(string team) where T : new()
        {
            var request = _requestFactory("teams/{team}", Method.GET);
            request.AddUrlSegment("team", team);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetVideo(string id)
        {
            return GetVideo<ExpandoObject>(id);
        }

        public T GetVideo<T>(string id) where T : new()
        {
            var request = _requestFactory("videos/{id}", Method.GET);
            request.AddUrlSegment("id", id);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        public dynamic GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.week)
        {
            return GetTopVideos<ExpandoObject>(game, pagingInfo, periodType);
        }

        public T GetTopVideos<T>(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.week) where T : new()
        {
            var request = _requestFactory("videos/top", Method.GET);
            AddPaging(request, pagingInfo);
            request.AddSafeParameter("game", game);
            request.AddParameter("period", periodType);
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }

        protected void AddPaging(IRestRequest request, PagingInfo pagingInfo)
        {
            if (pagingInfo == null) return;
            request.AddParameter("limit", pagingInfo.PageSize);
            request.AddParameter("offset", pagingInfo.Page - 1);
        }

        protected IRestClient RestClient { get {  return _restClient; } }
        protected Func<string, Method, IRestRequest> RequestFactory { get { return _requestFactory; } }
    }
}
