using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginUsers : IPlugin
    {
        Task<Task> OnUserVoiceStateUpdated(SocketUser user, SocketVoiceState oldState, SocketVoiceState newState);
        Task<Task> UserJoinedGuild(SocketGuildUser user);
    }
}
