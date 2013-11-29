using Twitch.Net.Enums;
using Twitch.Net.Helpers;

namespace Twitch.Net.Interfaces
{
    internal interface IAuthenticatedClientGeneric
    {
        T GetUserBlocks<T>(string user, PagingInfo pagingInfo = null) where T : new();
        T BlockUser<T>(string myUser, string userToBlock) where T : new();
        T DeleteBlock<T>(string myUser, string userToUnblock) where T : new();
        T GetChannel<T>() where T : new();
        T GetChannelEditors<T>(string channel) where T : new();
        T UpdateChannel<T>(string channel, string status = null, string game = null) where T : new();
        T ResetStreamKey<T>(string channel) where T : new();
        T TriggerCommerical<T>(string channel, CommercialLength length) where T : new();
        T FollowChannel<T>(string user, string channel) where T : new();
        T DeleteFollow<T>(string user, string channel) where T : new();
        T GetFollows<T>() where T : new();
        T GetSubscriptions<T>(string channel) where T : new();
        T GetUserSubscribedToChannel<T>(string user, string channel) where T : new();
        T GetChannelUserSubscribedTo<T>(string channel, string user) where T : new();
    }
}