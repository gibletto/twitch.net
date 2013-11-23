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
        TwitchList<Video> GetChannelVideos(string channel);
        Dictionary<string, object> GetChatLinks(string channel);
        TwitchList<Emoticon> GetEmoticons();
        TwitchList<Follow> GetChannelFollowers(string channel, PagingInfo pagingInfo = null);
        TwitchList<Follow> GetUserFollows(string user, PagingInfo pagingInfo = null);
        bool GetUserFollowingChannel(string user, string channel);
        dynamic GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false);
        dynamic GetIngests();
        dynamic GetRoot();
        dynamic SearchStreams(string query, PagingInfo info = null);
        dynamic SearchGames(string query, SearchType searchType = SearchType.Suggest, bool live = false);
        dynamic GetStream(string channel);
        dynamic GetStreams(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false, bool httpLiveStreaming = false);
        dynamic GetFeaturedSteams(PagingInfo info = null, bool httpLiveStreaming = false);
        dynamic GetStreamsSummary(PagingInfo info = null, bool httpLiveStreaming = false);
        dynamic GetTeams();
        dynamic GetTeam(string team);
        dynamic GetVideo(string id);
        dynamic GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.Week);
    }
}
