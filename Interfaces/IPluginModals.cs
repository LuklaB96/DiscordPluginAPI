using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordPluginAPI.Interfaces
{
    public interface IPluginModals : IPlugin
    {
        ModalBuilder[] ModalBuilders { get; }

        Task<Task> ModalSubmitted(SocketModal modal);
    }
}
