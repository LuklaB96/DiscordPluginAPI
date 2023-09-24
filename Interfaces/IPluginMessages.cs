using Discord;
using Discord.WebSocket;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginMessages : IPlugin
    {
        Task<Task> MessageReceived(SocketMessage message);
        Task<Task> MessageDeleted(Cacheable<IMessage, ulong> message, Cacheable<IMessageChannel, ulong> channel);
        Task<Task> MessageUpdated(Cacheable<IMessage, ulong> messageOld, SocketMessage messageNew, ISocketMessageChannel channel);
        Task<Task> MessageBulkDeleted(IReadOnlyCollection<Cacheable<IMessage, ulong>> messages, Cacheable<IMessageChannel, ulong> channel);
    }
}
