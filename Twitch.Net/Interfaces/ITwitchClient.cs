using Twitch.Net.Enums;
using Twitch.Net.Helpers;

namespace Twitch.Net.Interfaces
{
    public interface ITwitchClient
    {
        dynamic GetUser(string user);        
        dynamic GetChannel(string channel);
        dynamic GetChannelVideos(string channel, PagingInfo info = null, bool onlyBroadcasts = false);    
        dynamic GetChatLinks(string channel);
        dynamic GetEmoticons();
        dynamic GetChannelFollowers(string channel, PagingInfo pagingInfo = null);
        dynamic GetUserFollows(string user, PagingInfo pagingInfo = null);
        dynamic GetUserFollowingChannel(string user, string channel);
        dynamic GetTopGames(PagingInfo pagingInfo = null, bool httpLiveStreaming = false);
        dynamic GetIngests();
        dynamic GetRoot();
        dynamic SearchStreams(string query, PagingInfo info = null);
        dynamic SearchGames(string query, SearchType searchType = SearchType.suggest, bool live = false);
        dynamic GetStream(string channel);
        dynamic GetStreams(string game = null, string channel = null, PagingInfo info = null, bool embeddableOnly = false, bool httpLiveStreaming = false);
        dynamic GetFeaturedSteams(PagingInfo info = null, bool httpLiveStreaming = false);
        dynamic GetStreamSummary();
        dynamic GetTeams();
        dynamic GetTeam(string team);
        dynamic GetVideo(string id);
        dynamic GetTopVideos(string game = null, PagingInfo pagingInfo = null, PeriodType periodType = PeriodType.week);
    }
}
