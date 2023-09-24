using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginComponents : IPlugin
    {
        Task<Task> HandleComponent(SocketMessageComponent component);
    }
}
