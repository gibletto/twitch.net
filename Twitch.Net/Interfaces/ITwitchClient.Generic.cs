using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Net.Enums;
using Twitch.Net.Helpers;

namespace Twitch.Net.Interfaces
{
    internal interface ITwitchClientGeneric
    {
        T GetUser<T>(string user) where T : new();
        T GetChannel<T>(string channel) where T : new();
        T GetChannelVideos<T>(string channel, PagingInfo info = null, bool onlyBroadcasts = false) where T : new();
        T GetChatLinks<T>(string channel) where T : new();
        T GetEmoticons<T>() where T : new();
        T GetChannelFollowers<T>(string channel, PagingInfo pagingInfo = null) where T : new();
        T GetUserFollows<T>(string user, PagingInfo pagingInfo = null) where T : new();
        T GetUserFollowingChannel<T>(string user, string channel) where T : new();
        T GetTopGames<T>(PagingInfo pagingInfo = null, bool httpLiveStreaming = false) where T : new();
        T GetIngests<T>() where T : new();
        T GetRoot<T>() where T : new();
        T SearchStreams<T>(string query, PagingInfo info = null) where T : new();
        T SearchGames<T>(string query, SearchType searchType = SearchType.suggest, bool live = false) where T : new();
        T GetStream<T>(string channel) where T : new();
        T GetStreams<T>(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false, bool httpLiveStreaming = false) where T : new();
        T GetFeaturedSteams<T>(PagingInfo info = null, bool httpLiveStreaming = false) where T : new();
        T GetStreamSummary<T>() where T : new();
        T GetTeams<T>() where T : new();
        T GetTeam<T>(string team) where T : new();
        T GetVideo<T>(string id) where T : new();
        T GetTopVideos<T>(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.week) where T : new();
    }
}
