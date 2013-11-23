using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Net.Enums;

namespace Twitch.Net.Interfaces
{
    interface ITwitchClientFactory
    {
        ITwitchClient GetClient(ClientType clientType);
    }
}
