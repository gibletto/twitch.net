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
            return DynamicExtensions.FromDynamic<TwitchList<Follow>, Follow>(_client.GetChannelFollowers(channel, pagingInfo));
        }

        public TwitchList<Follow> GetUserFollows(string user, PagingInfo pagingInfo = null)
        {
            return DynamicExtensions.FromDynamic<TwitchList<Follow>, Follow>(_client.GetUserFollows(user, pagingInfo));
        }

        public Follow GetUserFollowingChannel(string user, string channel)
        {
            return DynamicExtensions.FromDynamic<Follow, Follow>(_client.GetUserFollowingChannel(user, channel));
        }

        public TwitchList<TopGame> GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false)
        {
            return DynamicExtensions.FromDynamic<TwitchList<TopGame>, TopGame>(_client.GetTopGames(pagingInfo, httpLiveStreaming));
        }

        public TwitchList<Ingest> GetIngests()
        {
            return DynamicExtensions.FromDynamic<TwitchList<Ingest>, Ingest>(_client.GetIngests());
        }

        public RootResult GetRoot()
        {
            return DynamicExtensions.FromDynamic<RootResult, RootResult>(_client.GetRoot());
        }

        public TwitchList<Stream> SearchStreams(string query, PagingInfo info = null)
        {
            return DynamicExtensions.FromDynamic<TwitchList<Stream>, Stream>(_client.SearchStreams(query, info));
        }

        public TwitchList<Game> SearchGames(string query, SearchType searchType = SearchType.Suggest, bool live = false)
        {
            return DynamicExtensions.FromDynamic<TwitchList<Game>, Game>(_client.SearchGames(query, searchType, live));
        }

        public StreamResult GetStream(string channel)
        {
            return DynamicExtensions.FromDynamic<StreamResult,StreamResult>(_client.GetStream(channel));
        }

        public TwitchList<Stream> GetStreams(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false,
            bool httpLiveStreaming = false)
        {
            return DynamicExtensions.FromDynamic<TwitchList<Stream>, Stream>(_client.GetStreams(game,channel,info,embeddableOnly,httpLiveStreaming));
        }

        public FeaturedResult GetFeaturedSteams(PagingInfo info = null, bool httpLiveStreaming = false)
        {
            return DynamicExtensions.FromDynamic<FeaturedResult, FeaturedResult>(_client.GetFeaturedSteams(info, httpLiveStreaming));
        }

        public StreamSummary GetStreamSummary()
        {
            return DynamicExtensions.FromDynamic<StreamSummary, StreamSummary>(_client.GetStreamSummary());
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
