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
            return DynamicExtensions.FromDynamic<User, User>(_client.GetUser(user));
        }

        public Channel GetChannel(string channel)
        {
            return DynamicExtensions.FromDynamic<Channel, Channel>(_client.GetChannel(channel));
        }

        public TwitchList<Video> GetChannelVideos(string channel, PagingInfo pagingInfo = null, bool onlyBroadcasts = false)
        {
            return DynamicExtensions.FromDynamic<TwitchList<Video>, Video>(_client.GetChannelVideos(channel, pagingInfo, onlyBroadcasts));
        }

        public ChatLinks GetChatLinks(string channel)
        {
            return DynamicExtensions.FromDynamic<ChatLinks, ChatLinks>(_client.GetChatLinks(channel));
        }

        public TwitchList<Emoticon> GetEmoticons()
        {
            return DynamicExtensions.FromDynamic<TwitchList<Emoticon>, Emoticon>(_client.GetEmoticons());
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

        public TwitchList<Team> GetTeams()
        {
            return DynamicExtensions.FromDynamic<TwitchList<Team>, Team>(_client.GetTeams());
        }

        public Team GetTeam(string team)
        {
            return DynamicExtensions.FromDynamic<Team, Team>(_client.GetTeam(team));
        }

        public Video GetVideo(string id)
        {
            return DynamicExtensions.FromDynamic<Video, Video>(_client.GetVideo(id));
        }

        public TwitchList<Video> GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.Week)
        {
            return DynamicExtensions.FromDynamic<TwitchList<Video>, Video>(_client.GetTopVideos(game, pagingInfo, periodType));
        }
    }
}
