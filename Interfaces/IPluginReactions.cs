using Discord.WebSocket;
using Discord;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginReactions : IPlugin
    {
        Task<Task> ReactionsCleared(IUserMessage message, Cacheable<IMessageChannel, ulong> channel);
        Task<Task> HandleReactionsRemovedForEmote(Cacheable<IUserMessage, ulong> message, Cacheable<IMessageChannel, ulong> channel, IEmote emote);
        Task<Task> ReactionAdded(IUserMessage message, Cacheable<IMessageChannel, ulong> channel, SocketReaction reaction);
        Task<Task> ReactionRemoved(IUserMessage message, Cacheable<IMessageChannel, ulong> channel, SocketReaction reaction);
    }
}
