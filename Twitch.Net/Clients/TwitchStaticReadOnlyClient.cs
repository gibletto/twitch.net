using System.Collections.Generic;
using Twitch.Net.Enums;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;

namespace Twitch.Net.Clients
{
    public class TwitchStaticReadOnlyClient : ITwitchStaticClient
    {
        private readonly ITwitchClient _client;

        public TwitchStaticReadOnlyClient(ITwitchClient client)
        {
            _client = client;
        }

        public User GetUser(string user)
        {
            return DynamicExtensions.FromDynamic<User>(_client.GetUser(user));
        }

        public Channel GetChannel(string channel)
        {
            throw new System.NotImplementedException();
        }

        public TwitchList<Video> GetChannelVideos(string channel)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Link> GetChatLinks(string channel)
        {
            throw new System.NotImplementedException();
        }

        public TwitchList<Emoticon> GetEmoticons()
        {
            throw new System.NotImplementedException();
        }

        public TwitchList<Follow> GetChannelFollowers(string channel, PagingInfo pagingInfo = null)
        {
            throw new System.NotImplementedException();
        }

        public TwitchList<Follow> GetUserFollows(string user, PagingInfo pagingInfo = null)
        {
            throw new System.NotImplementedException();
        }

        public bool GetUserFollowingChannel(string user, string channel)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetIngests()
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetRoot()
        {
            throw new System.NotImplementedException();
        }

        public dynamic SearchStreams(string query, PagingInfo info = null)
        {
            throw new System.NotImplementedException();
        }

        public dynamic SearchGames(string query, SearchType searchType = SearchType.Suggest, bool live = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetStream(string channel)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetStreams(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false,
            bool httpLiveStreaming = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetFeaturedSteams(PagingInfo info = null, bool httpLiveStreaming = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetStreamsSummary(PagingInfo info = null, bool httpLiveStreaming = false)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetTeams()
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetTeam(string team)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetVideo(string id)
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.Week)
        {
            throw new System.NotImplementedException();
        }
    }
}
