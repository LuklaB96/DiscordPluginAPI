using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginChannels : IPlugin
    {
        Task<Task> ChannelDestroyed(SocketChannel channel);
        Task<Task> ChannelCreated(SocketChannel channel);
        Task<Task> ChannelUpdated(SocketChannel channelOld,SocketChannel channelNew);
    }
}
