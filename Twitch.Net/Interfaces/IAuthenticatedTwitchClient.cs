using Twitch.Net.Enums;
using Twitch.Net.Helpers;

namespace Twitch.Net.Interfaces
{
    public interface IAuthenticatedTwitchClient
    {
        dynamic GetUserBlocks(string user, PagingInfo pagingInfo = null);
        dynamic BlockUser(string myUser, string userToBlock);
        dynamic DeleteBlock(string myUser, string userToUnblock);
        dynamic GetChannel();
        dynamic GetChannelEditors(string channel);
        dynamic UpdateChannel(string channel, string status = null, string game = null);
        dynamic ResetStreamKey(string channel);
        dynamic TriggerCommerical(string channel, CommercialLength length);
        dynamic FollowChannel(string user, string channel);
        dynamic DeleteFollow(string user, string channel);
        dynamic GetFollows();
        dynamic GetSubscriptions(string channel);
        dynamic GetUserSubscribedToChannel(string user, string channel);
        dynamic GetChannelUserSubscribedTo(string channel, string user);
    }
}
