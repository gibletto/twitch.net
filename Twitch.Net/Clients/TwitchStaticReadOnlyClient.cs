using Twitch.Net.Enums;
using Twitch.Net.Helpers;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;

namespace Twitch.Net.Clients
{
    public class TwitchStaticReadOnlyClient : ITwitchStaticClient
    {
        private readonly ITwitchClientGeneric _client;

        internal TwitchStaticReadOnlyClient(ITwitchClientGeneric client)
        {
            _client = client;
        }

        public User GetUser(string user)
        {
            return _client.GetUser<User>(user);
        }

        public Channel GetChannel(string channel)
        {
            return _client.GetChannel<Channel>(channel);
        }

        public TwitchList<Video> GetChannelVideos(string channel, PagingInfo pagingInfo = null, bool onlyBroadcasts = false)
        {
            return _client.GetChannelVideos<TwitchList<Video>>(channel, pagingInfo, onlyBroadcasts);
        }

        public ChatLinks GetChatLinks(string channel)
        {
            return _client.GetChatLinks<ChatLinks>(channel);
        }

        public TwitchList<Emoticon> GetEmoticons()
        {
            return _client.GetEmoticons<TwitchList<Emoticon>>();
        }

        public TwitchList<Follow> GetChannelFollowers(string channel, PagingInfo pagingInfo = null)
        {
            return _client.GetChannelFollowers<TwitchList<Follow>>(channel, pagingInfo);
        }

        public TwitchList<Follow> GetUserFollows(string user, PagingInfo pagingInfo = null)
        {
            return _client.GetUserFollows<TwitchList<Follow>>(user, pagingInfo);
        }

        public Follow GetUserFollowingChannel(string user, string channel)
        {
            return _client.GetUserFollowingChannel<Follow>(user, channel);
        }

        public TwitchList<TopGame> GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            return _client.GetTopGames<TwitchList<TopGame>>(pagingInfo, httpLiveStreaming);
        }

        public TwitchList<Ingest> GetIngests()
        {
            return _client.GetIngests<TwitchList<Ingest>>();
        }

        public RootResult GetRoot()
        {
            return _client.GetRoot<RootResult>();
        }

        public TwitchList<Stream> SearchStreams(string query, PagingInfo info = null)
        {
            return _client.SearchStreams<TwitchList<Stream>>(query, info);
        }

        public TwitchList<Game> SearchGames(string query, SearchType searchType = SearchType.suggest, bool live = false)
        {
            return _client.SearchGames<TwitchList<Game>>(query, searchType, live);
        }

        public StreamResult GetStream(string channel)
        {
            return _client.GetStream<StreamResult>(channel);
        }

        public TwitchList<Stream> GetStreams(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false,
            bool httpLiveStreaming = false)
        {
            return _client.GetStreams<TwitchList<Stream>>(game, channel, info, embeddableOnly, httpLiveStreaming);
        }

        public FeaturedResult GetFeaturedSteams(PagingInfo info = null, bool httpLiveStreaming = false)
        {
            return _client.GetFeaturedSteams<FeaturedResult>(info, httpLiveStreaming);
        }

        public StreamSummary GetStreamSummary()
        {
            return _client.GetStreamSummary<StreamSummary>();
        }

        public TwitchList<Team> GetTeams()
        {
            return _client.GetTeams<TwitchList<Team>>();
        }

        public Team GetTeam(string team)
        {
            return _client.GetTeam<Team>(team);
        }

        public Video GetVideo(string id)
        {
            return _client.GetVideo<Video>(id);
        }

        public TwitchList<Video> GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.week)
        {
            return _client.GetTopVideos<TwitchList<Video>>(game, pagingInfo, periodType);
        }
    }
}
