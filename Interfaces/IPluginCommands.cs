using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginCommands : IPlugin
    {
        Task<object> ExecuteSlashCommand(SocketSlashCommand command);
        Task<object> UserCommandExecuted(SocketUserCommand command);
        Task<object> MessageCommandExecuted(SocketMessageCommand command);
    }
}
