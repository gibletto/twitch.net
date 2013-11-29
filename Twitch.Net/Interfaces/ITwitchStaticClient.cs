using System.Collections.Generic;
using Twitch.Net.Enums;
using Twitch.Net.Helpers;
using Twitch.Net.Model;

namespace Twitch.Net.Interfaces
{
    interface ITwitchStaticClient
    {
        User GetUser(string user);
        Channel GetChannel(string channel);
        TwitchList<Video> GetChannelVideos(string channel, PagingInfo pagingInfo = null, bool onlyBroadcasts = false);
        ChatLinks GetChatLinks(string channel);
        TwitchList<Emoticon> GetEmoticons();
        TwitchList<Follow> GetChannelFollowers(string channel, PagingInfo pagingInfo = null);
        TwitchList<Follow> GetUserFollows(string user, PagingInfo pagingInfo = null);
        Follow GetUserFollowingChannel(string user, string channel);
        TwitchList<TopGame> GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false);
        TwitchList<Ingest> GetIngests();
        RootResult GetRoot();
        TwitchList<Stream> SearchStreams(string query, PagingInfo info = null);
        TwitchList<Game> SearchGames(string query, SearchType searchType = SearchType.suggest, bool live = false);
        StreamResult GetStream(string channel);
        TwitchList<Stream> GetStreams(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false, bool httpLiveStreaming = false);
        FeaturedResult GetFeaturedSteams(PagingInfo info = null, bool httpLiveStreaming = false);
        StreamSummary GetStreamSummary();
        TwitchList<Team> GetTeams();
        Team GetTeam(string team);
        Video GetVideo(string id);
        TwitchList<Video> GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.week);
    }
}
